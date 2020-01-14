using Model;
using Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Controllers
{
    public class PeopleController
    {
        private PisDbContext context;
        public PeopleController(PisDbContext context)
        {
            this.context = context;
        }

        public List<PeopleViewModel> GetList()
        {
            List<PeopleViewModel> result = context.Peoples.Select(rec => new
           PeopleViewModel
            {
                Id = rec.Id,
                FIO = rec.FIO,
                Owner = rec.Owner,
                NumberHouse = rec.Apartment.NumberHouse,
                NumberApartment = rec.Apartment.NumberApartment,
                Date = rec.Date,
                PeoplePrivileges = context.PeoplePrivileges
            .Where(recCI => recCI.PeopleId == rec.Id)
           .Select(recCI => new PeoplePrivilegeViewModel
           {
               Id = recCI.Id,
               PeopleId = recCI.PeopleId,
               PrivilegeId = recCI.PrivilegeId
           })
           .ToList()
            })
            .ToList();
            return result;
        }

        public PeopleViewModel GetElement(int id)
        {
            People element = context.Peoples.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new PeopleViewModel
                {
                    Id = element.Id,
                    FIO = element.FIO,
                    Owner = element.Owner,
                    ApartmentId = element.ApartmentId,
                    Date = element.Date,
                    NumberHouse = context.Apartments.FirstOrDefault(rec => rec.Id == element.ApartmentId).NumberHouse,
                    NumberApartment = context.Apartments.FirstOrDefault(rec => rec.Id == element.ApartmentId).NumberApartment,
                    PeoplePrivileges = context.PeoplePrivileges
                    .Where(recCI => recCI.PeopleId == element.Id)
                    .Select(recCI => new PeoplePrivilegeViewModel
                    {
                        Id = recCI.Id,
                        PeopleId = recCI.PeopleId,
                        PrivilegeId = recCI.PrivilegeId,
                        NamePrivilege = recCI.Privilege.NamePrivilege,
                        Multiplier = recCI.Privilege.Multiplier
                    })
                    .ToList()
                };
            }
            throw new Exception("Элемент не найден");
        }

        public void AddElement(People model)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    People element = context.Peoples.FirstOrDefault(rec =>
                   rec.FIO == model.FIO);
                    if (element != null)
                    {
                        throw new Exception("Уже есть жилец с таким ФИО");
                    }



                    element = new People
                    {
                        FIO = model.FIO,
                        Owner = model.Owner,
                        ApartmentId = model.ApartmentId,
                        Date = model.Date
                    };
                    context.Peoples.Add(element);
                    context.SaveChanges();
                    // убираем дубли по компонентам
                    var groupPrivileges = model.PeoplePrivileges
                     .GroupBy(rec => rec.PrivilegeId)
                    .Select(rec => new
                    {
                        PrivilegeId = rec.Key
                    });
                    // добавляем компоненты
                    foreach (var groupPrivilege in groupPrivileges)
                    {
                        context.PeoplePrivileges.Add(new PeoplePrivilege
                        {
                            PeopleId = element.Id,
                            PrivilegeId = groupPrivilege.PrivilegeId
                        });
                        context.SaveChanges();
                    }
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public void UpdElement(People model)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    People element = context.Peoples.FirstOrDefault(rec =>
                   rec.FIO == model.FIO && rec.Id != model.Id);
                    if (element != null)
                    {
                        throw new Exception("Уже есть жилец с таким ФИО");
                    }
                    element = context.Peoples.FirstOrDefault(rec => rec.Id == model.Id);
                    if (element == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                    element.FIO = model.FIO;
                    element.Owner = model.Owner;
                    element.ApartmentId = model.ApartmentId;
                    element.Date = model.Date;
                    context.SaveChanges();
                    // обновляем существуюущие компоненты
                    var privIds = model.PeoplePrivileges.AsEnumerable().Select(rec =>
                   rec.PrivilegeId).Distinct();
                    var updatePrivileges = context.PeoplePrivileges.Where(rec =>
                   rec.PeopleId == model.Id && privIds.Contains(rec.PrivilegeId));
                    foreach (var updatePrivilege in updatePrivileges)
                    {
                        //  updateIngredient.Count =
                        // model.CanFoodIngredients.FirstOrDefault(rec => rec.Id == updateIngredient.Id).Count;
                    }
                    context.SaveChanges();
                    context.PeoplePrivileges.RemoveRange(context.PeoplePrivileges.Where(rec =>
                    rec.PeopleId == model.Id && !privIds.Contains(rec.PrivilegeId)));
                    context.SaveChanges();
                    // новые записи
                    var groupPrivileges = model.PeoplePrivileges.AsEnumerable()
                    .Where(rec => rec.Id == 0)
                   .GroupBy(rec => rec.PrivilegeId)
                   .Select(rec => new
                   {
                       PrivilegeId = rec.Key
                   });
                    foreach (var groupPrivilege in groupPrivileges)
                    {
                        PeoplePrivilege elementPP =
                       context.PeoplePrivileges.FirstOrDefault(rec => rec.PeopleId == model.Id &&
                       rec.PrivilegeId == groupPrivilege.PrivilegeId);
                        if (elementPP != null)
                        {
                            //  elementPP.Count += groupIngredient.Count;
                            context.SaveChanges();
                        }
                        else
                        {
                            context.PeoplePrivileges.Add(new PeoplePrivilege
                            {
                                PeopleId = model.Id,
                                PrivilegeId = groupPrivilege.PrivilegeId
                            });
                            context.SaveChanges();
                        }
                    }
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public void DelElement(int id)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    People element = context.Peoples.FirstOrDefault(rec => rec.Id ==
                   id);
                    if (element != null)
                    {
                        // удаяем записи по льготам при удалении жильца
                        context.PeoplePrivileges.RemoveRange(context.PeoplePrivileges.Where(rec =>
                        rec.PeopleId == id));
                        context.Peoples.Remove(element);
                        context.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("Элемент не найден");
                    }
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public List<Apartment> GetListApartment(string HouseNumber)
        {
            List<Apartment> result = context.Apartments.AsEnumerable().Where(rec => rec.NumberHouse == HouseNumber).Select(rec => new Apartment
            {
                Id = rec.Id,
                NumberHouse = rec.NumberHouse,
                NumberApartment = rec.NumberApartment,
                ApartmentSize = rec.ApartmentSize
            })
            .ToList();
            return result;
        }

        // Поиск по фамилии или номеру квартиры
        public List<PeopleViewModel> SearchByFIO(string Fio)
        {
            int NumberApart = -1;
            int num;
            bool isNum = int.TryParse(Fio, out num);
            if (isNum)
            {
                NumberApart = Convert.ToInt32(Fio);
            }
            List<PeopleViewModel> result = context.Peoples.Where(rec => rec.FIO.StartsWith(Fio) || rec.Apartment.NumberApartment == NumberApart).Select(rec => new
           PeopleViewModel
            {
                Id = rec.Id,
                FIO = rec.FIO,
                Owner = rec.Owner,
                NumberHouse = rec.Apartment.NumberHouse,
                NumberApartment = rec.Apartment.NumberApartment,
                Date = rec.Date
            })
            .ToList();
            return result;
        }

        //Выборка жильцов по номеру дома
        public List<PeopleViewModel> SelectByHouseNumber(string HouseNumber)
        {
            List<PeopleViewModel> result = context.Peoples.Where(rec => rec.Apartment.NumberHouse.StartsWith(HouseNumber)).Select(rec => new
           PeopleViewModel
            {
                Id = rec.Id,
                FIO = rec.FIO,
                Owner = rec.Owner,
                NumberHouse = rec.Apartment.NumberHouse,
                NumberApartment = rec.Apartment.NumberApartment,
                Date = rec.Date
            })
            .ToList();
            return result;
        }

        //Квартиры в которых количество жильцов больше заданного кол-ва
        public List<PeopleViewModel> SelectByCountPeople(int CountPeople)
        {
            var dt = context.Database.SqlQuery<PeopleViewModel>("select Apartments.NumberHouse, Apartments.NumberApartment, Count(ApartmentId) as 'CountPeople' from People, Apartments where People.ApartmentId = Apartments.Id Group by Apartments.NumberHouse, Apartments.NumberApartment Having Count(ApartmentId) > " + CountPeople + "");
            List<PeopleViewModel> result = dt.ToList();
            return result;
        }

        //Расчет жилплощади на одного человека в каждой квартире
        public List<PeopleViewModel> SelectAverageLivingSpace()
        {
            var dt = context.Database.SqlQuery<PeopleViewModel>("select Apartments.NumberHouse, Apartments.NumberApartment, Apartments.ApartmentSize/Count(ApartmentId) as 'AverageLivingSpace'  from People, Apartments where People.ApartmentId = Apartments.Id Group by Apartments.NumberHouse, Apartments.NumberApartment, Apartments.ApartmentSize");
            List<PeopleViewModel> result = dt.ToList();
            return result;
        }

   
        public void TradeApartment(int apart1, int apart2)
        {
            var updateAparts = context.Peoples.Where(rec =>
                   rec.ApartmentId == apart1);
            foreach (var updateApart in updateAparts)
            {
                updateApart.ApartmentId = apart2;
            }

            var updateApartments = context.Peoples.Where(rec =>
                   rec.ApartmentId == apart2);
            foreach (var updateApartment in updateApartments)
            {
                updateApartment.ApartmentId = apart1;
            }
            context.SaveChanges();
        }
    }
}

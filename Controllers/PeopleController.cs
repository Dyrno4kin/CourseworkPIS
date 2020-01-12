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
                        ApartmentId = model.ApartmentId
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

        public List<Apartment> GetListA(string HouseNumber)
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

    
    }
}

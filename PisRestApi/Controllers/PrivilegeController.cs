using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PisRestApi.Controllers
{
    public class PrivilegeController : ApiController
    {
        private PisDbContext context;
        public PrivilegeController(PisDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IHttpActionResult GetList()
        {
            List<Privilege> result = context.Privileges.AsEnumerable().Select(rec => new Privilege
            {
                Id = rec.Id,
                NamePrivilege = rec.NamePrivilege,
                TypePrivilege = rec.TypePrivilege,
                Multiplier = rec.Multiplier
            })
            .ToList();
            var list = result;
            if (list == null)
            {
                InternalServerError(new Exception("Нет данных"));
            }
            return Ok(list);
        }

        public Privilege GetElement(int id)
        {
            Privilege element = context.Privileges.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new Privilege
                {
                    Id = element.Id,
                    NamePrivilege = element.NamePrivilege,
                    TypePrivilege = element.TypePrivilege,
                    Multiplier = element.Multiplier
                };
            }
            throw new Exception("Элемент не найден");
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {

            var element = GetElement(id);
            if (element == null)
            {
                InternalServerError(new Exception("Нет данных"));
            }
            return Ok(element);
        }

        [HttpPost]
        public void AddElement(Privilege model)
        {
            Privilege element = context.Privileges.FirstOrDefault(rec => rec.NamePrivilege ==
           model.NamePrivilege);
            if (element != null)
            {
                throw new Exception("Уже есть льгота с таким названием");
            }
            context.Privileges.Add(new Privilege
            {
                NamePrivilege = model.NamePrivilege,
                TypePrivilege = model.TypePrivilege,
                Multiplier = model.Multiplier
            });
            context.SaveChanges();
        }

        [HttpPost]
        public void UpdElement(Privilege model)
        {
            Privilege element = context.Privileges.FirstOrDefault(rec => rec.NamePrivilege ==
          model.NamePrivilege && rec.Id != model.Id);
            if (element != null)
            {
                throw new Exception("Уже есть льгота с таким названием");
            }
            element = context.Privileges.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            element.NamePrivilege = model.NamePrivilege;
            element.TypePrivilege = model.TypePrivilege;
            element.Multiplier = model.Multiplier;
            context.SaveChanges();
        }

        [HttpPost]
        public void DelElement(Privilege model)
        {
            Privilege element = context.Privileges.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                context.Privileges.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
    }
}

using Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Controllers
{
    public class MainController
    {
        private PisDbContext context;
        private readonly EncryptionController encryptionService;

        public MainController(PisDbContext context, EncryptionController encryptionService)
        {
            this.context = context;
            this.encryptionService = encryptionService;
        }

        public List<User> GetList()
        {
            List<User> result = context.Users.Select(rec => new User
            {
                Id = rec.Id,
                UserFIO = rec.UserFIO,
                Login = rec.Login,
                Password = rec.Password,
                UserRole = rec.UserRole
            })
            .ToList();
            return result;
        }
        public User GetElement(int id)
        {
            User element = context.Users.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new User
                {
                    Id = element.Id,
                    UserFIO = element.UserFIO,
                    Login = element.Login,
                    Password = element.Password,
                    UserRole = element.UserRole
                };
            }
            throw new Exception("Элемент не найден");
        }

        public User GetElement(string login, string password)
        {
            string pass = encryptionService.Encrypt("Login", password);
            User element = context.Users.FirstOrDefault(rec => rec.Login == login && rec.Password == pass);
            if (element != null)
            {
                return new User
                {
                    Id = element.Id,
                    UserFIO = element.UserFIO,
                    Login = element.Login,
                    Password = element.Password,
                    UserRole = element.UserRole
                };
            }
            throw new Exception("Неверный логин или пароль");
        }

        public void AddElement(User model)
        {
            User element = context.Users.FirstOrDefault(rec => rec.UserFIO == model.UserFIO || rec.Login == model.Login);
            if (element != null)
            {
                throw new Exception("Уже есть пользователь с таким ФИО или логином");
            }
            element = new User
            {
                Password = model.Password,
                Login = model.Login,
                UserRole = model.UserRole,
                UserFIO = model.UserFIO
            };
            context.Users.Add(element);
            context.SaveChanges();
        }
    }
}

using Controllers;
using Model;
using System;
using System.Data.Entity;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;

namespace View
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = BuildUnityContainer();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<FormMain>());
        }

        public static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<DbContext, PisDbContext>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<PeopleController>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<PrivilegeController>(new
           HierarchicalLifetimeManager());

            return currentContainer;
        }
    }
}

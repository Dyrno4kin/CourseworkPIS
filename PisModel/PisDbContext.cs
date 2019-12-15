﻿using System.Data.Entity;

namespace Model
{
    public class PisDbContext : DbContext
    {
        public PisDbContext() : base("PisDatabase")
        {
            //настройки конфигурации для entity
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
            var ensureDLLIsCopied =
           System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<People> Peoples { get; set; }
        public DbSet<PeoplePrivilege> PeoplePrivileges { set; get; }
        public DbSet<Privilege> Privileges { set; get; }
    }
}

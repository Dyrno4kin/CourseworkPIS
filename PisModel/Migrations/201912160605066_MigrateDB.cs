namespace PISModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PeoplePrivileges", "NamePrivilege", c => c.String());
            AddColumn("dbo.PeoplePrivileges", "Multiplier", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PeoplePrivileges", "Multiplier");
            DropColumn("dbo.PeoplePrivileges", "NamePrivilege");
        }
    }
}

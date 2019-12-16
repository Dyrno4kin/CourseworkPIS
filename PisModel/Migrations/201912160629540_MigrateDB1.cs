namespace PISModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PeoplePrivileges", "PrivilegeName", c => c.String());
            AddColumn("dbo.PeoplePrivileges", "PrivilegeMultiplier", c => c.Double(nullable: false));
            DropColumn("dbo.PeoplePrivileges", "NamePrivilege");
            DropColumn("dbo.PeoplePrivileges", "Multiplier");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PeoplePrivileges", "Multiplier", c => c.Double(nullable: false));
            AddColumn("dbo.PeoplePrivileges", "NamePrivilege", c => c.String());
            DropColumn("dbo.PeoplePrivileges", "PrivilegeMultiplier");
            DropColumn("dbo.PeoplePrivileges", "PrivilegeName");
        }
    }
}

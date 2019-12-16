namespace PISModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TrirdMigration1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.PeoplePrivileges", "PrivilegeName");
            DropColumn("dbo.PeoplePrivileges", "PrivilegeMultiplier");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PeoplePrivileges", "PrivilegeMultiplier", c => c.Double(nullable: false));
            AddColumn("dbo.PeoplePrivileges", "PrivilegeName", c => c.String());
        }
    }
}

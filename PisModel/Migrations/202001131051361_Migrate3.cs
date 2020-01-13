namespace PISModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migrate3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "Date");
        }
    }
}

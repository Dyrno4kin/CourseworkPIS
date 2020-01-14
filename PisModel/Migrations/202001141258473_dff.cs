namespace PISModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dff : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.User",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    UserFIO = c.String(),
                    Login = c.String(),
                    Password = c.String(),
                    UserRole = c.String()
                })
                .PrimaryKey(t => t.Id);
        }
        
        public override void Down()
        {
        }
    }
}

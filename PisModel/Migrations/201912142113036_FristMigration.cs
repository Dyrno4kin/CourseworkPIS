namespace PISModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FristMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Apartments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NumberHouse = c.String(),
                        NumberApartment = c.Int(nullable: false),
                        ApartmentSize = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FIO = c.String(),
                        Owner = c.Boolean(nullable: false),
                        ApartmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Apartments", t => t.ApartmentId, cascadeDelete: true)
                .Index(t => t.ApartmentId);
            
            CreateTable(
                "dbo.PeoplePrivileges",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PeopleId = c.Int(nullable: false),
                        PrivilegeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.PeopleId, cascadeDelete: true)
                .ForeignKey("dbo.Privileges", t => t.PrivilegeId, cascadeDelete: true)
                .Index(t => t.PeopleId)
                .Index(t => t.PrivilegeId);
            
            CreateTable(
                "dbo.Privileges",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NamePrivilege = c.String(),
                        TypePrivilege = c.String(),
                        Multiplier = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PeoplePrivileges", "PrivilegeId", "dbo.Privileges");
            DropForeignKey("dbo.PeoplePrivileges", "PeopleId", "dbo.People");
            DropForeignKey("dbo.People", "ApartmentId", "dbo.Apartments");
            DropIndex("dbo.PeoplePrivileges", new[] { "PrivilegeId" });
            DropIndex("dbo.PeoplePrivileges", new[] { "PeopleId" });
            DropIndex("dbo.People", new[] { "ApartmentId" });
            DropTable("dbo.Privileges");
            DropTable("dbo.PeoplePrivileges");
            DropTable("dbo.People");
            DropTable("dbo.Apartments");
        }
    }
}

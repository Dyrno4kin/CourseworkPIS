namespace PISModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ReceiptsForPayments",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Sum = c.Double(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Apartments", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.СonsumedService",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TypeService = c.String(),
                        Count = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        ApartmentId = c.Int(nullable: false),
                        TarifId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Apartments", t => t.ApartmentId, cascadeDelete: true)
                .ForeignKey("dbo.Tarifs", t => t.TarifId, cascadeDelete: true)
                .Index(t => t.ApartmentId)
                .Index(t => t.TarifId);
            
            CreateTable(
                "dbo.Tarifs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameTarif = c.String(),
                        UnitPrice = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.СonsumedService", "TarifId", "dbo.Tarifs");
            DropForeignKey("dbo.СonsumedService", "ApartmentId", "dbo.Apartments");
            DropForeignKey("dbo.ReceiptsForPayments", "Id", "dbo.Apartments");
            DropIndex("dbo.СonsumedService", new[] { "TarifId" });
            DropIndex("dbo.СonsumedService", new[] { "ApartmentId" });
            DropIndex("dbo.ReceiptsForPayments", new[] { "Id" });
            DropTable("dbo.Tarifs");
            DropTable("dbo.СonsumedService");
            DropTable("dbo.ReceiptsForPayments");
        }
    }
}

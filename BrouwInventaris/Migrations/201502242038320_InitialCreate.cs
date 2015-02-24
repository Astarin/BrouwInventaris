namespace BrouwInventaris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aankoops",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Prijs = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Aankoopdatum = c.DateTime(nullable: false),
                        Hoeveelheid = c.Int(nullable: false),
                        Artikel_Id = c.Int(),
                        User_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Artikels", t => t.Artikel_Id)
                .ForeignKey("dbo.UserProfile", t => t.User_UserId)
                .Index(t => t.Artikel_Id)
                .Index(t => t.User_UserId);
            
            CreateTable(
                "dbo.Artikels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naam = c.String(),
                        Omschrijving = c.String(),
                        Verpakking = c.Int(),
                        Alfa = c.Decimal(precision: 18, scale: 2),
                        Ebc = c.Int(),
                        MaximumStorting = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserProfile",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        UserName = c.String(),
                        Brouwerij_Id = c.Int(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Brouwerijs", t => t.Brouwerij_Id)
                .Index(t => t.Brouwerij_Id);
            
            CreateTable(
                "dbo.Brouwerijs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naam = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Aankoops", "User_UserId", "dbo.UserProfile");
            DropForeignKey("dbo.UserProfile", "Brouwerij_Id", "dbo.Brouwerijs");
            DropForeignKey("dbo.Aankoops", "Artikel_Id", "dbo.Artikels");
            DropIndex("dbo.UserProfile", new[] { "Brouwerij_Id" });
            DropIndex("dbo.Aankoops", new[] { "User_UserId" });
            DropIndex("dbo.Aankoops", new[] { "Artikel_Id" });
            DropTable("dbo.Brouwerijs");
            DropTable("dbo.UserProfile");
            DropTable("dbo.Artikels");
            DropTable("dbo.Aankoops");
        }
    }
}

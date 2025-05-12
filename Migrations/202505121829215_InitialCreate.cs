namespace foy5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bolums",
                c => new
                    {
                        BolumID = c.Int(nullable: false, identity: true),
                        BolumAd = c.String(nullable: false),
                        FakulteID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BolumID)
                .ForeignKey("dbo.Fakultes", t => t.FakulteID, cascadeDelete: true)
                .Index(t => t.FakulteID);
            
            CreateTable(
                "dbo.Fakultes",
                c => new
                    {
                        FakulteID = c.Int(nullable: false, identity: true),
                        FakulteAd = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.FakulteID);
            
            CreateTable(
                "dbo.Ogrencis",
                c => new
                    {
                        OgrenciID = c.Int(nullable: false, identity: true),
                        Ad = c.String(nullable: false),
                        Soyad = c.String(nullable: false),
                        BolumID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OgrenciID)
                .ForeignKey("dbo.Bolums", t => t.BolumID, cascadeDelete: true)
                .Index(t => t.BolumID);
            
            CreateTable(
                "dbo.OgrenciDers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        OgrenciID = c.Int(nullable: false),
                        DersID = c.Int(nullable: false),
                        Yil = c.Int(nullable: false),
                        Yariyil = c.Int(nullable: false),
                        Vize = c.Int(nullable: false),
                        Final = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Ogrencis", t => t.OgrenciID, cascadeDelete: true)
                .Index(t => t.OgrenciID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OgrenciDers", "OgrenciID", "dbo.Ogrencis");
            DropForeignKey("dbo.Ogrencis", "BolumID", "dbo.Bolums");
            DropForeignKey("dbo.Bolums", "FakulteID", "dbo.Fakultes");
            DropIndex("dbo.OgrenciDers", new[] { "OgrenciID" });
            DropIndex("dbo.Ogrencis", new[] { "BolumID" });
            DropIndex("dbo.Bolums", new[] { "FakulteID" });
            DropTable("dbo.OgrenciDers");
            DropTable("dbo.Ogrencis");
            DropTable("dbo.Fakultes");
            DropTable("dbo.Bolums");
        }
    }
}

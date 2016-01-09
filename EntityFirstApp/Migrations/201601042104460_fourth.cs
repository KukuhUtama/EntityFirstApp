namespace EntityFirstApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fourth : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserProfiles",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Address = c.String(maxLength: 100),
                        AddedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Id, cascadeDelete: true)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 25),
                        Email = c.String(nullable: false),
                        Password = c.String(),
                        AddedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rents",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        VideoId = c.Long(nullable: false),
                        UserId = c.Long(nullable: false),
                        RentingLength = c.Int(nullable: false),
                        RentingCost = c.Int(nullable: false),
                        AddedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId)
                .ForeignKey("dbo.Videos", t => t.VideoId, cascadeDelete: true)
                .Index(t => t.VideoId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Videos",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 25),
                        Genre = c.String(nullable: false),
                        RentPrice = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                        AddedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rents", "VideoId", "dbo.Videos");
            DropForeignKey("dbo.Rents", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserProfiles", "Id", "dbo.Users");
            DropIndex("dbo.Rents", new[] { "UserId" });
            DropIndex("dbo.Rents", new[] { "VideoId" });
            DropIndex("dbo.UserProfiles", new[] { "Id" });
            DropTable("dbo.Videos");
            DropTable("dbo.Rents");
            DropTable("dbo.Users");
            DropTable("dbo.UserProfiles");
        }
    }
}

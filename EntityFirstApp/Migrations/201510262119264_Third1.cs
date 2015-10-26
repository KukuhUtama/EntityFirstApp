namespace EntityFirstApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Third1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Age = c.Byte(nullable: false),
                        IsCurrent = c.Boolean(nullable: false),
                        AddedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        IP = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        MaximumStrength = c.Long(nullable: false),
                        AddedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        IP = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.StudentCourse",
                c => new
                    {
                        CourseId = c.Long(nullable: false),
                        StudentId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.CourseId, t.StudentId })
                .ForeignKey("dbo.Students", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.CourseId)
                .Index(t => t.StudentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentCourse", "StudentId", "dbo.Courses");
            DropForeignKey("dbo.StudentCourse", "CourseId", "dbo.Students");
            DropIndex("dbo.StudentCourse", new[] { "StudentId" });
            DropIndex("dbo.StudentCourse", new[] { "CourseId" });
            DropTable("dbo.StudentCourse");
            DropTable("dbo.Courses");
            DropTable("dbo.Students");
        }
    }
}

namespace Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admin",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 40),
                        UserName = c.String(nullable: false, maxLength: 40),
                        Password = c.String(nullable: false, maxLength: 40),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Field",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 40),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 40),
                        BirthDate = c.DateTime(nullable: false),
                        GovernateID = c.Int(nullable: false),
                        NeighborhoodID = c.Int(nullable: false),
                        FieldID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Neighborhood", t => t.NeighborhoodID)
                .ForeignKey("dbo.Governate", t => t.GovernateID, cascadeDelete: true)
                .ForeignKey("dbo.Field", t => t.FieldID, cascadeDelete: true)
                .Index(t => t.GovernateID)
                .Index(t => t.NeighborhoodID)
                .Index(t => t.FieldID);
            
            CreateTable(
                "dbo.Governate",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Neighborhood",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        GovernateID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Governate", t => t.GovernateID, cascadeDelete: true)
                .Index(t => t.GovernateID);
            
            CreateTable(
                "dbo.StudentTeacher",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TeacherID = c.Int(nullable: false),
                        StudentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Teacher", t => t.TeacherID, cascadeDelete: true)
                .ForeignKey("dbo.Student", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.TeacherID)
                .Index(t => t.StudentID);
            
            CreateTable(
                "dbo.Teacher",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 40),
                        BirthDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Student", "FieldID", "dbo.Field");
            DropForeignKey("dbo.StudentTeacher", "StudentID", "dbo.Student");
            DropForeignKey("dbo.StudentTeacher", "TeacherID", "dbo.Teacher");
            DropForeignKey("dbo.Student", "GovernateID", "dbo.Governate");
            DropForeignKey("dbo.Neighborhood", "GovernateID", "dbo.Governate");
            DropForeignKey("dbo.Student", "NeighborhoodID", "dbo.Neighborhood");
            DropIndex("dbo.StudentTeacher", new[] { "StudentID" });
            DropIndex("dbo.StudentTeacher", new[] { "TeacherID" });
            DropIndex("dbo.Neighborhood", new[] { "GovernateID" });
            DropIndex("dbo.Student", new[] { "FieldID" });
            DropIndex("dbo.Student", new[] { "NeighborhoodID" });
            DropIndex("dbo.Student", new[] { "GovernateID" });
            DropTable("dbo.Teacher");
            DropTable("dbo.StudentTeacher");
            DropTable("dbo.Neighborhood");
            DropTable("dbo.Governate");
            DropTable("dbo.Student");
            DropTable("dbo.Field");
            DropTable("dbo.Admin");
        }
    }
}

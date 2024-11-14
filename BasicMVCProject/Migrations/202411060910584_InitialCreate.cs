namespace BasicMVCProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()

        {
            CreateTable(
                "dbo.oldCampus",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
           
            
            CreateTable(
                "dbo.oldStudents",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        CampusID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.oldCampus", t => t.CampusID)
                .Index(t => t.CampusID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.oldStudents", "CampusID", "dbo.oldCampus");
            DropIndex("dbo.oldStudents", new[] { "CampusID" });
            DropTable("dbo.oldStudents");
            DropTable("dbo.oldCampus");
        }
    }
}

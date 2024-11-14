namespace BasicMVCProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CategoryNameValidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Campus", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Students", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Students", "Address", c => c.String(nullable: false, maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Address", c => c.String());
            AlterColumn("dbo.Students", "Name", c => c.String());
            AlterColumn("dbo.Campus", "Name", c => c.String());
        }
    }
}

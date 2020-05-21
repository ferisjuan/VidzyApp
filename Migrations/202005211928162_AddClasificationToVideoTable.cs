namespace EFCourse.Vidzy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddClasificationToVideoTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Videos", "Clasification", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Videos", "Clasification");
        }
    }
}

namespace EFCourse.Vidzy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PrePopulateDataIntoGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Name) VALUES ('Action')");
            Sql("INSERT INTO Genres (Name) VALUES ('Drama')");
            Sql("INSERT INTO Genres (Name) VALUES ('Fiction')");
        }
        
        public override void Down()
        {
        }
    }
}

namespace EFCourse.Vidzy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PrePopulateDataIntoGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Genre) ('Action')");
            Sql("INSERT INTO Genres (Genre) ('Drama')");
            Sql("INSERT INTO Genres (Genre) ('Fiction')");
        }
        
        public override void Down()
        {
        }
    }
}

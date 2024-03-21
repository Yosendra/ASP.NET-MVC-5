namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Populate_Genres_Table : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Name) " +
                "VALUES " +
                "('Action'), " +
                "('Thriller'), " +
                "('Family'), " +
                "('Romance'), " +
                "('Comedy'), " +
                "('Anime')");
        }
        
        public override void Down()
        {
        }
    }
}

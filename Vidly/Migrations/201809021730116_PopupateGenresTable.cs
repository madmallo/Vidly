namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopupateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO dbo.Genres (Id, Name) VALUES (1, 'Comedy')");
            Sql("INSERT INTO dbo.Genres (Id, Name) VALUES (2, 'Action')");
            Sql("INSERT INTO dbo.Genres (Id, Name) VALUES (3, 'Family')");
            Sql("INSERT INTO dbo.Genres (Id, Name) VALUES (4, 'Romance')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM dbo.Genres");
        }
    }
}

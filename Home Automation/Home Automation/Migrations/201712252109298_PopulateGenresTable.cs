namespace Home_Automation.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert  into Genres (Id, Name) VALUES (1, 'Jazz')");
            Sql("Insert  into Genres (Id, Name) VALUES (2, 'Blues')");
            Sql("Insert  into Genres (Id, Name) VALUES (3, 'Rock')");
            Sql("Insert  into Genres (Id, Name) VALUES (4, 'Country')");

        }

        public override void Down()
        {
            Sql("delete from genres where Id In (1,2,3,4)");
        }
    }
}

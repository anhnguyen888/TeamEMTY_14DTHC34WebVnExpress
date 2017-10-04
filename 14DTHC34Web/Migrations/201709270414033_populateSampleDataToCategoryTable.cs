namespace _14DTHC34Web.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class populateSampleDataToCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Categories (Id, Name) Values(1, 'Development')");
            Sql("Insert into Categories (Id, Name) Values(2, 'Marketing online')");
        }

        public override void Down()
        {
        }
    }
}

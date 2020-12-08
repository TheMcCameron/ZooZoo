namespace ZooZoo.EntityFramework.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateZooAnimalTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO ZooAnimals (Zoo_Id, Animal_Id)" +
            "VALUES ('1', '1')");
        }

        public override void Down()
        {
            Sql("DELETE FROM ZooAnimals" +
                "WHERE (Zoo_Id = '1' and Animal_Id = '1')" +
                "AND Animal_Id = '1'");
        }
    }
}

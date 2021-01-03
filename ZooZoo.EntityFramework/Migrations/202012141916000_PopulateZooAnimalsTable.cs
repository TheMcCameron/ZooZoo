namespace ZooZoo.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateZooAnimalsTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO ZooAnimals " +
                "VALUES (1, 1);");
        }
        
        public override void Down()
        {
            Sql("DROP FROM ZooAnimals;");
        }
    }
}

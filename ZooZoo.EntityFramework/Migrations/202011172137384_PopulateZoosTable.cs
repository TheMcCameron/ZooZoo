namespace ZooZoo.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateZoosTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Zoos (Name)" +
                "VALUES ('Atlanta')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Zoos" +
                "WHERE Name = 'Atlanta'");
        }
    }
}

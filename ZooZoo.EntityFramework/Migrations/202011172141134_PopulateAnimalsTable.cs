namespace ZooZoo.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateAnimalsTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Animals (Name, Description)" +
                "VALUES ('Leopard', 'Feline, Carnivorous.')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Animals" +
                "WHERE Name='Leopard'");
        }
    }
}

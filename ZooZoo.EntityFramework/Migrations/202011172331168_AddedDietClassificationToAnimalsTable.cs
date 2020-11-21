namespace ZooZoo.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDietClassificationToAnimalsTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Animals", "DietClassification", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Animals", "DietClassification");
        }
    }
}

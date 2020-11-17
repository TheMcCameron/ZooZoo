namespace ZooZoo.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialZooZooDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Animals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Description = c.String(nullable: false, maxLength: 800),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Zoos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ZooAnimals",
                c => new
                    {
                        Zoo_Id = c.Int(nullable: false),
                        Animal_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Zoo_Id, t.Animal_Id })
                .ForeignKey("dbo.Zoos", t => t.Zoo_Id, cascadeDelete: true)
                .ForeignKey("dbo.Animals", t => t.Animal_Id, cascadeDelete: true)
                .Index(t => t.Zoo_Id)
                .Index(t => t.Animal_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ZooAnimals", "Animal_Id", "dbo.Animals");
            DropForeignKey("dbo.ZooAnimals", "Zoo_Id", "dbo.Zoos");
            DropIndex("dbo.ZooAnimals", new[] { "Animal_Id" });
            DropIndex("dbo.ZooAnimals", new[] { "Zoo_Id" });
            DropTable("dbo.ZooAnimals");
            DropTable("dbo.Zoos");
            DropTable("dbo.Animals");
        }
    }
}

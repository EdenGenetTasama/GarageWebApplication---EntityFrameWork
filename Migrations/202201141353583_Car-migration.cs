namespace GarageWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Carmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OwnerName = c.String(),
                        CarNum = c.Int(nullable: false),
                        IsFixed = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cars");
        }
    }
}

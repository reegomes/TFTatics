namespace UIConsole.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Champions : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Champions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Class = c.String(),
                        Origin = c.String(),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Healt = c.Int(nullable: false),
                        Armor = c.Int(nullable: false),
                        MR = c.Int(nullable: false),
                        DPS = c.Int(nullable: false),
                        DMG = c.Int(nullable: false),
                        ASpd = c.Int(nullable: false),
                        Range = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            DropTable("dbo.Produtoes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Produtoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Value = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Category = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            DropTable("dbo.Champions");
        }
    }
}

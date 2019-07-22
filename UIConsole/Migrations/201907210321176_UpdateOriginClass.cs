namespace UIConsole.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateOriginClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TeamComps",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CompName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Champions", "TCClass_ID", c => c.Int());
            AddColumn("dbo.Champions", "TCOrigin_ID", c => c.Int());
            AddColumn("dbo.Champions", "TeamComp_ID", c => c.Int());
            CreateIndex("dbo.Champions", "TCClass_ID");
            CreateIndex("dbo.Champions", "TCOrigin_ID");
            CreateIndex("dbo.Champions", "TeamComp_ID");
            AddForeignKey("dbo.Champions", "TCClass_ID", "dbo.TeamComps", "ID");
            AddForeignKey("dbo.Champions", "TCOrigin_ID", "dbo.TeamComps", "ID");
            AddForeignKey("dbo.Champions", "TeamComp_ID", "dbo.TeamComps", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Champions", "TeamComp_ID", "dbo.TeamComps");
            DropForeignKey("dbo.Champions", "TCOrigin_ID", "dbo.TeamComps");
            DropForeignKey("dbo.Champions", "TCClass_ID", "dbo.TeamComps");
            DropIndex("dbo.Champions", new[] { "TeamComp_ID" });
            DropIndex("dbo.Champions", new[] { "TCOrigin_ID" });
            DropIndex("dbo.Champions", new[] { "TCClass_ID" });
            DropColumn("dbo.Champions", "TeamComp_ID");
            DropColumn("dbo.Champions", "TCOrigin_ID");
            DropColumn("dbo.Champions", "TCClass_ID");
            DropTable("dbo.TeamComps");
        }
    }
}

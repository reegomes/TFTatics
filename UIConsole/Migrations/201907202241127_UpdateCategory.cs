namespace UIConsole.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCategory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produtoes", "Category", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Produtoes", "Category");
        }
    }
}

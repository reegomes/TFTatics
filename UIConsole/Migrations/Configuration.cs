namespace UIConsole.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<UIConsole.DBChampions>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "UIConsole.DBProduto";
        }

        protected override void Seed(UIConsole.DBChampions context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            //
            //
            //  Aqui eu posso j� criar dados no banco, antes dele ser criado em si
            //
            //  
            //
            //
            //
            //
            //
            //
        }
    }
}

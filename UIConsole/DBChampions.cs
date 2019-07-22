using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIConsole
{
    public class DBChampions:DbContext

    {
        public DbSet<Champion> Champions { get; set; }
        public DbSet<TeamComp> TeamComps { get; set; }

        /*
        public DbSet<TeamComp> TCClass { get; set; }
        public DbSet<TeamComp> TCOrigin { get; set; }
        */
    }
}

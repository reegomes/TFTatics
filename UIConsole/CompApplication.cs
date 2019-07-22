using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIConsole
{
    public class CompApplication
    {
        public DBChampions db { get; set; }
        public CompApplication()
        {
            db = new DBChampions();
        }

        public void Create(TeamComp teamComp)
        {
            db.TeamComps.Add(teamComp);
            db.SaveChanges();
        }

        public IEnumerable<TeamComp> ListComps()
        {
            return db.TeamComps.ToList();
        }

        public void Change(TeamComp teamComp)
        {
            TeamComp teamCompToChange = db.TeamComps.Where(x => x.ID == teamComp.ID).First();
            teamCompToChange.CompName = teamComp.CompName;
            db.SaveChanges();
        }

        public void Delete(int ID)
        {
            TeamComp teamCompToDelete = db.TeamComps.Where(x => x.ID == ID).First();
            db.Set<TeamComp>().Remove(teamCompToDelete);
            db.SaveChanges();
        }
    }
}

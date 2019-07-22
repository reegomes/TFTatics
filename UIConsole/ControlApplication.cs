using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace UIConsole
{
    public class ControlApplication
    {
        public DBChampions db { get; set; }
        

        public ControlApplication()
        {
            db = new DBChampions();
        }

        public void Create(Champion champion)
        {
            db.Champions.Add(champion);
            db.SaveChanges();
        }

        public void CreateTeamComp(TeamComp teamComp)
        {
            db.TeamComps.Add(teamComp);
            db.SaveChanges();
        } 

        public IEnumerable<Champion> ListChampion()
        {
            return db.Champions.Include(x=> x.TeamComp).ToList();
            //return db.Champions.ToList();
        }

        public void Change(Champion champion)
        {
            Champion championToChange = db.Champions.Where(x => x.ID == champion.ID).First();
            championToChange.Name = champion.Name;
            db.SaveChanges();
        }

        public void Delete(int ID)
        {
            Champion championToDelete = db.Champions.Where(x => x.ID == ID).First();
            db.Set<Champion>().Remove(championToDelete);
            db.SaveChanges();
        }

        internal void CreateTeamComp(ICollection<Champion> listChampions)
        {
            throw new NotImplementedException();
        }

        //Sem função por enquanto
        public string InitialChampion(Champion champion)
        {
            //Champion championInitial = db.Champions.Where(x => x.Name == champion.Name).First();
            //string a = championInitial.Name;
            return null;
        }

        //Sem função por enquanto
        public static void SugestedComposition(Champion champion)
        {
            // TO DO
        }
    }
}

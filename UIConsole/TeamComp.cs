using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIConsole
{
    public class TeamComp
    {
        /*public TeamComp(int iD, string compName, List<Champion> listChampions)
        {
            ID = iD;
            CompName = compName;
            ListChampions = listChampions;
        }
        public TeamComp(string compName, List<Champion> listChampions)
        {
            CompName = compName;
            ListChampions = listChampions;
        }
        public TeamComp(string compName)
        {
            CompName = compName;
        }*/

        public int ID { get; set; }
        public string CompName { get; set; }


        public virtual IEnumerable<Champion> Champions { get; set; }
        public virtual IEnumerable<Champion> TCClass { get; set; }
        public virtual IEnumerable<Champion> TCOrigin { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIConsole
{
    public class Champion
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string Origin { get; set; }
        public decimal Cost { get; set; }
        public int Healt { get; set; }
        public int Armor { get; set; }
        public int MR { get; set; }
        public int DPS { get; set; }
        public int DMG { get; set; }
        public int ASpd { get; set; }
        public int Range { get; set; }
        public TeamComp TCClass { get; set; }
        public TeamComp TCOrigin { get; set; }
        public TeamComp TeamComp { get; set; }
    }
}

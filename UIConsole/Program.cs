using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {

            ControlApplication app = new ControlApplication();
            Champion champion01 = new Champion();

            /*
            {
                Name = "Aurelion Sol",
                Class = "Sorcerer",
                Origin = "Dragon"
            };*/

            champion01.Name = "Shyvana";
            //champion01.Class = "Shapeshifter";
            //champion01.Origin = "Dragon";

            //Cria o champion
            //app.Create(champion01);

            //Altera o champion
            //app.Alterar(champion01);

            //Excluir champion
            //champion01.ID = 2;
            //app.Excluir(2);

            //app.InitialChampion(champion01);

            foreach (var championOnList in app.ListChampion())
            {
                Console.WriteLine("ID: {0} - Champion Name: {1} - Class {2} - Origin {3}", championOnList.ID, championOnList.Name, championOnList.Class, championOnList.Origin);
            }





            CompApplication appComp = new CompApplication();
            TeamComp teamcomp01 = new TeamComp();

            teamcomp01.CompName = "Wild Sorcerers";
            //appComp.Create(teamcomp01);
            //appComp.Delete(2);

            foreach (var teamComp in appComp.ListComps())
            {
                Console.WriteLine("{0} - {1}", teamcomp01.ID, teamcomp01.CompName);
            }

            Console.WriteLine();
            //Console.WriteLine(app.InitialChampion(champion01).ToString());
            Console.WriteLine("//");
            if(champion01.Name == "Shyvana")
            {
                Console.WriteLine("Composition suggested with {0}: {1}",champion01.Name, teamcomp01.CompName);
                Console.WriteLine("Wild Sorcerers: Shyvana, Aurelion Sol, Nidalee, Warwick, Gnar, Morgana, Ahri");
                Console.WriteLine("Wild 4 // Dragon 2 // Shapeshifters 3 // Sorcerer 3");
                Console.WriteLine("Alternate Comp: Demon or Brawler.");
            }
            Console.WriteLine("//");


            Console.ReadKey();

            // Gerador do script de banco de dados
            // > Update-Database -Script -SourceMigration:$InitialDatabase -TargetMigration:"Last Migration Here"

            // Atualizador do banco de dados
            // > Add-Migration "Add name of migration" 
            // > Update-Database -Verbose

            // Atualizador para rollback de update
            // > Update-Database -TargetMigration:"add name of rollback migration" 

            // Caso eu queira reverter um rollback
            // > Update-Database -TargetMigration:"add name of migration" 
        }
    }
}

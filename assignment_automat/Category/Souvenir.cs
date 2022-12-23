using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_automat.Category
{
    internal class Souvenir : AMachine
    {
        public Souvenir(int number,string name, int cost, string description) : base(name, description, cost, number)
        {
        }
        public static void SouvenirList()       //Skapar en lista för att använda som andra menyval
        {
            List<Souvenir> list = new List<Souvenir>();
            list.Add(new Souvenir(1, "accessoarer", 50, "Olika svenska accessoarer"));
            list.Add(new Souvenir(2, "Vykort", 10, "Olika svenska vykort"));
            list.Add(new Souvenir(3, "Souvenirer", 20, "Olika svenska Souvenirer"));
            foreach(Souvenir item in list)
            {
                Console.WriteLine("[" + item.Number + "] " + item.Name + "| " + "Från " + item.Cost + "kr| " + item.Description);
            }
        }
    }
}

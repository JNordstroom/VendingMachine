using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_automat.Category
{
    internal class Drink : AMachine
    {
        public Drink(int number, string name, int cost , string description) : base(name, description, cost, number)
        {
        }
        public static void DrinkList() //Skapar en lista för att använda som andra menyval
        {
            List<Drink> list = new List<Drink>();
            list.Add(new Drink(1, "Vatten", 10, "Från svenska bergskällor"));
            list.Add(new Drink(2, "Läsk", 15, "Kolsyrade sockerdrickor"));
            list.Add(new Drink(3, "Energidricka", 20, "Sömnlöshet på burk"));
            foreach (Drink item in list)
            {
                Console.WriteLine("[" + item.Number + "] " + item.Name + "| " + "Från " + item.Cost + "kr| " + item.Description);
            }
        }
    }
}

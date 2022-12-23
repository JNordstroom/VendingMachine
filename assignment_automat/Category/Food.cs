using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_automat.Category
{
    internal class Food : AMachine
    {
        
        public Food(int number, string name, int cost, string description) : base(name, description, cost, number)
        {
            
        }
        public static void FoodList()       //Skapar en lista för att använda som andra menyval
        {
            List<Food> list = new List<Food>();
            list.Add(new Food(1, "Pizza", 65, "Svenska delikatess pizzor"));
            list.Add(new Food(2, "Smörgåsar", 10, "Svenska favoriter"));
            list.Add(new Food(3, "Chips", 20, "Svenenska klassiker "));
            foreach (Food item in list)
            {
                Console.WriteLine("[" + item.Number + "] " + item.Name + "| " + "Från " + item.Cost + "kr| " + item.Description);
            }
        }
    }
}

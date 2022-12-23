using assignment_automat.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_automat.DrinkFolder
{
    internal class Water : Drink, IMachine
    {
        public Water(int number, string name, int cost, string description) : base(number, name, cost, description)
        {
        }
        public static void WaterImplementation()
        {
            Console.Clear();
            Wallet.CheckSaldo();
            Water water = new(1, "Vatten", 5, "Kranvatten");
            Water SparklingWater = new(2, "Kolsyrat vatten", 15, "Bubbelvatten");                   //Skapar objekt och ger dem värden och displayar dem
            Water SmaksattVatten = new(3, "Smaksatt vatten", 20, "Vatten med smak av päron");
            Console.WriteLine("Vilke vatten får det lov att vara?");
            Console.WriteLine($"[{water.Number}] {water.Name}: {water.Cost}kr: {water.Description}");
            Console.WriteLine($"[{SparklingWater.Number}] {SparklingWater.Name}: {SparklingWater.Cost}kr: {SparklingWater.Description}");
            Console.WriteLine($"[{SmaksattVatten.Number}] {SmaksattVatten.Name}: {SmaksattVatten.Cost}kr: {SmaksattVatten.Description}");

            var userInput = Console.ReadLine();
            if (userInput.ToString() == "1")
            {
                Console.Clear();
                Console.WriteLine($"{water.Name}, kostar {water.Cost}");                
                Console.WriteLine("Produktbeskrvning:");
                water.Desc();               //besrkiver produkterna
                Console.WriteLine("är du säker, Ja/Nej");
                var controlCheck = Console.ReadLine();
                if (controlCheck.ToString().ToLower() == "Ja".ToLower())
                {
                    var checkIfValidPurchase = water.Cost;                  // gör en kontroll check 
                    if (Wallet.Saldo < checkIfValidPurchase)
                    {
                        Console.Clear();
                        Console.WriteLine("Du har inte tillräckligt med pengar\ngå till menyn för att lägga in mer!");
                        Console.ReadLine();
                    }
                    else if (Wallet.Saldo >= checkIfValidPurchase)
                    {
                        Console.Clear();
                        Wallet.ReturnFunds(checkIfValidPurchase);                   //Drar pengar samt köper och använder produkten. 
                        water.Buy();
                        water.Use();
                        Console.ReadLine();
                    }
                }
                else if (controlCheck.ToString().ToLower() == "nej".ToLower())
                {
                    Console.Clear();
                    Console.WriteLine("Du återgår till menyn!");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Felaktig inmatning försök igen!");       //Felhantering
                    Console.ReadLine();
                }
            }
            else if (userInput.ToString() == "2")
            {
                Console.Clear();
                Console.WriteLine($"{SparklingWater.Name}, kostar {SparklingWater.Cost}");
                Console.WriteLine("Produktbeskrvning:");
                SparklingWater.Desc();
                Console.WriteLine("är du säker, Ja/Nej");
                var controlCheck = Console.ReadLine();
                if (controlCheck.ToString().ToLower() == "Ja".ToLower())
                {
                    var checkIfValidPurchase = SparklingWater.Cost;
                    if (Wallet.Saldo < checkIfValidPurchase)
                    {
                        Console.Clear();
                        Console.WriteLine("Du har inte tillräckligt med pengar\ngå till menyn för att lägga in mer!");
                        Console.ReadLine();
                    }
                    else if (Wallet.Saldo >= checkIfValidPurchase)
                    {
                        Console.Clear();
                        Wallet.ReturnFunds(checkIfValidPurchase);
                        SparklingWater.Buy();
                        SparklingWater.Use();
                        Console.ReadLine();
                    }
                }
                else if (controlCheck.ToString().ToLower() == "nej".ToLower())
                {
                    Console.Clear();
                    Console.WriteLine("Du återgår till menyn!");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Felaktig inmatning försök igen!");
                    Console.ReadLine();
                }
            }
            else if (userInput.ToString() == "3")
            {
                Console.Clear();
                Console.WriteLine($"{SmaksattVatten.Name}, kostar {SmaksattVatten.Cost}");
                Console.WriteLine("Produktbeskrvning:");
                SmaksattVatten.Desc();
                Console.WriteLine("är du säker, Ja/Nej");
                var controlCheck = Console.ReadLine();
                if (controlCheck.ToString().ToLower() == "Ja".ToLower())
                {
                    var checkIfValidPurchase = SmaksattVatten.Cost;
                    if (Wallet.Saldo < checkIfValidPurchase)
                    {
                        Console.Clear();
                        Console.WriteLine("Du har inte tillräckligt med pengar\ngå till menyn för att lägga in mer!");
                        Console.ReadLine();
                    }
                    else if (Wallet.Saldo >= checkIfValidPurchase)
                    {
                        Console.Clear();
                        Wallet.ReturnFunds(checkIfValidPurchase);
                        SmaksattVatten.Buy();
                        SmaksattVatten.Use();
                        Console.ReadLine();
                    }
                }
                else if (controlCheck.ToString().ToLower() == "nej".ToLower())
                {
                    Console.Clear();
                    Console.WriteLine("Du återgår till menyn!");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Felaktig inmatning försök igen!");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Felaktig inmatning försök igen!");
                Console.ReadLine();
            }
        }
        public void MyDrinkList()  // Skapar en lista för menyval
        {
            List<Water> list = new List<Water>();
            list.Add(new Water(1, "Vatten", 5, "Vanligt kranvatten"));
            list.Add(new Water(2, "Kolsyrat vatten", 20, "Kolsyrat vatten med mycket bubblor"));
            list.Add(new Water(3, "Käll vatten", 44, "Vatten från dem svenska källorna i norr"));
            foreach (Water item in list)
            {
                Console.WriteLine("[" + item.Number + "] " + item.Name + "| " + item.Cost + "kr| " + item.Description);
            }

        }

        public void Buy()
        {
            Console.WriteLine("Du köpte vatten");
        }

        public void Desc()
        {
            Console.WriteLine("Är du en av dem som tar en nyttigare väg i livet, då har vi vattnet för dig :)");
        }

        public void Use()
        {
            
            Console.WriteLine("Vill du öppna din dricka? Ja/nej");
            var use = Console.ReadLine();
            if (use.ToLower() == "ja".ToLower())
                Console.WriteLine("Knäpper upp och tar sig en sipp");
            else if (use.ToLower() == "Nej".ToLower())
                Console.WriteLine("Lägg ner den i väskan då");
        }
    }
}

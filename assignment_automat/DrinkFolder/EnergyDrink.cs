using assignment_automat.Category;
using assignment_automat.FoodFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_automat.DrinkFolder
{
    internal class EnergyDrink : Drink, IMachine
    {
        //Jag har kommenterat koden i dem följande tre klasserna under Drinkfolder samt Categoryt för det är annars bara rena upprepningar

        public EnergyDrink(int number, string name, int cost, string description) : base(number, name, cost, description)
        {
        }

        public static void EnergyDrinkImplementation()
        {
            Console.Clear();
            Wallet.CheckSaldo();
            EnergyDrink Redbull = new(1, "Redbull", 25, "Redbull ger dig vingar");      //skapar mina objekt 
            EnergyDrink Monster = new(2, "Monster", 30, "Monster for the gamers");
            EnergyDrink PowerKing = new(3, "Powerking", 15, "Perfekt till maten");
            Console.WriteLine("Vilken dricka får det lov att vara?");
            Console.WriteLine($"[{Redbull.Number}] {Redbull.Name}: {Redbull.Cost}kr: {Redbull.Description}");       //Skriver ut mina objekt
            Console.WriteLine($"[{Monster.Number}] {Monster.Name}: {Monster.Cost}kr: {Monster.Description}");
            Console.WriteLine($"[{PowerKing.Number}] {PowerKing.Name}: {PowerKing.Cost}kr: {PowerKing.Description}");

            var userInput = Console.ReadLine();
            if (userInput.ToString() == "1")
            {
                Console.Clear();
                Console.WriteLine($"{Redbull.Name}, kostar {Redbull.Cost}");
                Console.WriteLine("Produktbeskrvning:");
                Redbull.Desc();                                                     //Beskrivning innan köp
                Console.WriteLine("är du säker, Ja/Nej");
                var controlCheck = Console.ReadLine();
                if (controlCheck.ToString().ToLower() == "Ja".ToLower())
                {
                    var checkIfValidPurchase = Redbull.Cost;            //kontrollerar saldo inför köp
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
                        Redbull.Buy();                                      //Köper produkten
                        Redbull.Use();                                      //Använder produkten
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
            else if (userInput.ToString() == "2")
            {
                Console.Clear();
                Console.WriteLine($"{Monster.Name}, kostar {Monster.Cost}");            //Skriver ut namn och kostnad
                Console.WriteLine("Produktbeskrvning:");
                Monster.Desc();
                Console.WriteLine("är du säker, Ja/Nej");                           //Gör en kontrol check på att man vill köpa varan
                var controlCheck = Console.ReadLine();
                if (controlCheck.ToString().ToLower() == "Ja".ToLower())
                {
                    var checkIfValidPurchase = Monster.Cost;
                    if (Wallet.Saldo < checkIfValidPurchase)                        //saldo check
                    {
                        Console.Clear();
                        Console.WriteLine("Du har inte tillräckligt med pengar\ngå till menyn för att lägga in mer!");
                        Console.ReadLine();
                    }
                    else if (Wallet.Saldo >= checkIfValidPurchase)                  //Går saldot igenom köper och använder
                    {
                        Console.Clear();
                        Wallet.ReturnFunds(checkIfValidPurchase);
                        Monster.Buy();
                        Monster.Use();
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
                Console.WriteLine($"{PowerKing.Name}, kostar {PowerKing.Cost}");            // Samma som föregående case
                Console.WriteLine("Produktbeskrvning:");
                PowerKing.Desc();
                Console.WriteLine("är du säker, Ja/Nej");
                var controlCheck = Console.ReadLine();
                if (controlCheck.ToString().ToLower() == "Ja".ToLower())
                {
                    var checkIfValidPurchase = PowerKing.Cost;
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
                        PowerKing.Buy();
                        PowerKing.Use();
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
        public void MyEnergyDrinkList()                             //Skapar en lista för menyval
        {
            List<EnergyDrink> list = new List<EnergyDrink>();
            list.Add(new EnergyDrink(1, "Redbull", 25, "Rebull ger dig vingar"));
            list.Add(new EnergyDrink(2, "Monster", 30, "Sockerbomb på burk"));
            list.Add(new EnergyDrink(3, "Powerking", 15, "Med smak av rost"));
            foreach (EnergyDrink item in list)
            {
                Console.WriteLine("[" + item.Number + "] " + item.Name + "| " + item.Cost + "kr| " + item.Description);
            }

        }
        //Interrface implementation till mina produkter
        public void Buy()
        {
            Console.WriteLine("Du köpte en energidricka");
        }

        public void Desc()
        {
            Console.WriteLine("Behöver du energi för att orka med dagen?\nkanske är detta hjälpen du behöver(mest troligen inte)");
        }

        public void Use()
        {
            Console.WriteLine("Vill du öppna din dricka? Ja/nej");
            var use = Console.ReadLine();
            if (use.ToLower() == "Yes".ToLower())
                Console.WriteLine("Knäpper upp och tar sig en sipp");
            else if(use.ToLower() == "Nej".ToLower())
                Console.WriteLine("Lägg ner den i väskan då");
        }
    }
}

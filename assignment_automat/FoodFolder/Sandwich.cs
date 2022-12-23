using assignment_automat.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_automat.FoodFolder
{
    internal class Sandwich : Food, IMachine
    {
        public Sandwich(int number, string name, int cost, string description) : base(number, name, cost, description)
        {
        }
        public static void SandwichImplementation()
        {
            Console.Clear();
            Wallet.CheckSaldo();
            Sandwich bacon = new(1, "Bacon", 60, "Bacon macka");
            Sandwich Kyckling = new(2, "Kyckling curry", 85, "Kyckling baguette");
            Sandwich OstSkinka = new(3, "Ost och skinka", 90, "Ost och skinkbaguette");
            Console.WriteLine("Vilken Smörgås får det lov att vara?");
            Console.WriteLine($"[{bacon.Number}] {bacon.Name}: {bacon.Cost}kr: {bacon.Description}");
            Console.WriteLine($"[{Kyckling.Number}] {Kyckling.Name}: {Kyckling.Cost}kr: {Kyckling.Description}");
            Console.WriteLine($"[{OstSkinka.Number}] {OstSkinka.Name}: {OstSkinka.Cost}kr: {OstSkinka.Description}");

            var userInput = Console.ReadLine();
            if (userInput.ToString() == "1")
            {
                Console.Clear();
                Console.WriteLine($"{bacon.Name}, kostar {bacon.Cost}");
                Console.WriteLine("Produktbeskrvning:");
                bacon.Desc();
                Console.WriteLine("är du säker, Ja/Nej");
                var controlCheck = Console.ReadLine();
                if (controlCheck.ToString().ToLower() == "Ja".ToLower())
                {
                    var checkIfValidPurchase = bacon.Cost;
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
                        bacon.Buy();
                        bacon.Use();
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
                Console.WriteLine($"{Kyckling.Name}, kostar {Kyckling.Cost}");
                Console.WriteLine("Produktbeskrvning:");
                Kyckling.Desc();
                Console.WriteLine("är du säker, Ja/Nej");
                var controlCheck = Console.ReadLine();
                if (controlCheck.ToString().ToLower() == "Ja".ToLower())
                {
                    var checkIfValidPurchase = Kyckling.Cost;
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
                        Kyckling.Buy();
                        Kyckling.Use();
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
                Console.WriteLine($"{OstSkinka.Name}, kostar {OstSkinka.Cost}");
                Console.WriteLine("Produktbeskrvning:");
                OstSkinka.Desc();
                Console.WriteLine("är du säker, Ja/Nej");
                var controlCheck = Console.ReadLine();
                if (controlCheck.ToString().ToLower() == "Ja".ToLower())
                {
                    var checkIfValidPurchase = OstSkinka.Cost;
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
                        OstSkinka.Buy();
                        OstSkinka.Use();
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
        public void MySandwichList()
        {
            List<Sandwich> list = new List<Sandwich>();
            list.Add(new Sandwich(1, "Bacon", 20, "Krämig kräm med baconbitar"));
            list.Add(new Sandwich(2, "kyckling", 33, "Välstekt kyckling och curry"));
            list.Add(new Sandwich(3, "ost och skinka", 15, "Torr och tråkig"));
            foreach (Sandwich item in list)
            {
                Console.WriteLine("[" + item.Number + "] " + item.Name + "| "  + item.Cost + "kr| " + item.Description);
            }

        }
        public void Buy()
        {
            Console.WriteLine("Köper den utsökta smörgåsen");
        }

        public void Desc()
        {
            Console.WriteLine("två halvor med något emellan, alltså en macka :)");
        }

        public void Use()
        {
            Console.WriteLine("Vill du äta mackan nu? ja/nej");
            var eat = Console.ReadLine();
            if (eat.ToLower() == "ja".ToLower())
                Console.WriteLine("Äter först dem torra kanterna\nför att sen njuta av den mjuka mitten");
            
            else if (eat.ToLower() == "nej".ToLower())
                Console.WriteLine("Lägger undan mackan i ryggsäcken");
                
        }
    }
}

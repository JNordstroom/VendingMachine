using assignment_automat.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_automat.SouvenirFolder
{
    internal class Vykort : Souvenir, IMachine
    {
        public Vykort(int number, string name, int cost, string description) : base(number, name, cost, description)
        {
        }
        public static void VykortImplementation()
        {
            Console.Clear();
            Wallet.CheckSaldo();
            Vykort Malmö = new(1, "Malmö Vykort", 25, "Vykort på malmö Stadium");
            Vykort Stockholm = new(2, "Stockholm vykort", 35, "Vykort på Globen");
            Vykort Göteborg = new(3, "Göteborg", 30, "Vykort på Gothia towers");
            Console.WriteLine("Vilket vykort får det lov att vara?");
            Console.WriteLine($"[{Malmö.Number}] {Malmö.Name}: {Malmö.Cost}kr: {Malmö.Description}");
            Console.WriteLine($"[{Stockholm.Number}] {Stockholm.Name}: {Stockholm.Cost}kr: {Stockholm.Description}");
            Console.WriteLine($"[{Göteborg.Number}] {Göteborg.Name}: {Göteborg.Cost}kr: {Göteborg.Description}");

            var userInput = Console.ReadLine();
            if (userInput.ToString() == "1")
            {
                Console.Clear();
                Console.WriteLine($"{Malmö.Name}, kostar {Malmö.Cost}");
                Console.WriteLine("Produktbeskrvning:");
                Malmö.Desc();
                Console.WriteLine("är du säker, Ja/Nej");
                var controlCheck = Console.ReadLine();
                if (controlCheck.ToString().ToLower() == "Ja".ToLower())
                {
                    var checkIfValidPurchase = Malmö.Cost;
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
                        Malmö.Buy();
                        Malmö.Use();
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
                Console.WriteLine($"{Stockholm.Name}, kostar {Stockholm.Cost}");
                Console.WriteLine("Produktbeskrvning:");
                Stockholm.Desc();
                Console.WriteLine("är du säker, Ja/Nej");
                var controlCheck = Console.ReadLine();
                if (controlCheck.ToString().ToLower() == "Ja".ToLower())
                {
                    var checkIfValidPurchase = Stockholm.Cost;
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
                        Stockholm.Buy();
                        Stockholm.Use();
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
                Console.WriteLine($"{Göteborg.Name}, kostar {Göteborg.Cost}");
                Console.WriteLine("Produktbeskrvning:");
                Göteborg.Desc();
                Console.WriteLine("är du säker, Ja/Nej");
                var controlCheck = Console.ReadLine();
                if (controlCheck.ToString().ToLower() == "Ja".ToLower())
                {
                    var checkIfValidPurchase = Göteborg.Cost;
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
                        Göteborg.Buy();
                        Göteborg.Use();
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

        public static void MyVykortList()
        {
            List<Vykort> list = new List<Vykort>();
            list.Add(new Vykort(1, "Malmö vykort", 25, "Malmö stadium"));
            list.Add(new Vykort(2, "Stockholm vykort", 35, "Globen"));
            list.Add(new Vykort(3, "Göteborg vykort", 30, "Gothia towers"));
            foreach (Vykort item in list)
            {
                Console.WriteLine("[" + item.Number + "] " + item.Name + "| " + item.Cost + "kr| " + item.Description);
            }

        }
        public void Buy()
        {
            Console.WriteLine("Du köpte ett vykort");
        }

        public void Desc()
        {
            Console.WriteLine("Välj vilket vykort du vill ha info om!");
            MyVykortList();
            
            var userChoice = Console.ReadLine();
            if (userChoice.ToString() == "1".ToString())
                Console.WriteLine("Ett vykort på Malmö stad");
            else if (userChoice.ToString() == "2".ToString())
                Console.WriteLine("Ett vykort på Stockholm stad");
            else if (Console.ReadLine() == "3".ToString())
                Console.WriteLine("Ett vykort på Göteborg stad");
        }

        public void Use()
        {
            Console.WriteLine("Skriver en adress och postar vykortet hem");

        }
    }
}

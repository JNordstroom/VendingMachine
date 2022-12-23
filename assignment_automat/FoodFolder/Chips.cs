using assignment_automat.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_automat.FoodFolder
{

    /*
     * Gör sammanfattning av kommentarerna, 
     * Jag skapar nya objekt för mina olika produkter.
     * Jag skriver ut dem olika produkterna med en foreachloop
     * Användaren gör ett menyval och ges produktinformation.
     * Gör en penga kontroll och har du pengar erbjuds du köpa produkten och använda den
     * annars får du felmeddelande och efterfrågas att lägga in mer pengar.
     */
    internal class Chips : Food, IMachine
    {
        public Chips(int number, string name, int cost, string description) : base(number, name, cost, description)
        {
        }
        public static void ChipsImplementation()
        {
            Console.Clear();
            Wallet.CheckSaldo();
            Chips Dill = new(1, "Dill och gräslök", 60, "Grovräflade chips");
            Chips Sourcream = new(2, "Sourcream", 85, "Finräflade chips");
            Chips Grill = new(3, "Grill", 90, "Grovräflade chips");
            Console.WriteLine("Vilken Chipspåse får det lov att vara?");
            Console.WriteLine($"[{Dill.Number}] {Dill.Name}: {Dill.Cost}kr: {Dill.Description}");
            Console.WriteLine($"[{Sourcream.Number}] {Sourcream.Name}: {Sourcream.Cost}kr: {Sourcream.Description}");
            Console.WriteLine($"[{Grill.Number}] {Grill.Name}: {Grill.Cost}kr: {Grill.Description}");

            var userInput = Console.ReadLine();
            if (userInput.ToString() == "1")
            {
                Console.Clear();
                Console.WriteLine($"{Dill.Name}, kostar {Dill.Cost}");
                Console.WriteLine("Produktbeskrvning:");
                Dill.Desc();
                Console.WriteLine("är du säker, Ja/Nej");
                var controlCheck = Console.ReadLine();
                if (controlCheck.ToString().ToLower() == "Ja".ToLower())
                {
                    var checkIfValidPurchase = Dill.Cost;
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
                        Dill.Buy();
                        Dill.Use();
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
                Console.WriteLine($"{Sourcream.Name}, kostar {Sourcream.Cost}");
                Console.WriteLine("Produktbeskrvning:");
                Sourcream.Desc();
                Console.WriteLine("är du säker, Ja/Nej");
                var controlCheck = Console.ReadLine();
                if (controlCheck.ToString().ToLower() == "Ja".ToLower())
                {
                    var checkIfValidPurchase = Sourcream.Cost;
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
                        Sourcream.Buy();
                        Sourcream.Use();
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
                Console.WriteLine($"{Grill.Name}, kostar {Grill.Cost}");
                Console.WriteLine("Produktbeskrvning:");
                Grill.Desc();
                Console.WriteLine("är du säker, Ja/Nej");
                var controlCheck = Console.ReadLine();
                if (controlCheck.ToString().ToLower() == "Ja".ToLower())
                {
                    var checkIfValidPurchase = Grill.Cost;
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
                        Grill.Buy();
                        Grill.Use();
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

        public void MyChipsList()  //Lista för menyval
        {
            List<Chips> list = new List<Chips>();
            list.Add(new Chips(1, "Dill & gräslök", 20, "Grovräfflade chips"));
            list.Add(new Chips(2, "Sourcream", 15, "Finräfflade godsaker"));
            list.Add(new Chips(3, "Grillchips", 20, "Världens mest överskattade chips"));
            foreach (Chips item in list)
            {
                Console.WriteLine("[" + item.Number + "] " + item.Name + "| "  + item.Cost + "kr| " + item.Description);
            }

        }

        //implementerar mina metoder i interfacet.
        public void Buy()
        {
            Console.WriteLine("Köper den Lilla chipspåsen");
        }

        public void Desc()
        {
            Console.WriteLine("Ångest på påse om vi ska vara ärlig :)");
        }

        public void Use()
        {
            Console.WriteLine("Kränger du hela påsen direkt? ja/nej ");
            var eat = Console.ReadLine();
            if (eat.ToLower() == "ja".ToLower())
                Console.WriteLine("smaskar högjutt i sig chipsen");

            else if (eat.ToLower() == "nej".ToLower())
                Console.WriteLine("Lägger undan mackan i ryggsäcken");

        }
    }
}

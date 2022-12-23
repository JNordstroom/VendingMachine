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
    internal class Pizza : Food , IMachine
    {

        public Pizza(int number, string name, int cost, string description) : base(number, name, cost, description)
        {
            
        }
        public static void Pizzaimplementation()
        {
            Wallet.CheckSaldo();
            Pizza vesuvio = new(1, "Vesuvio", 60, "Ost och skinka");
            Pizza kebab = new(2, "Kebab", 85, "Nötkött med sallad");
            Pizza kyckling = new(3, "Kyckling", 90, "Kyckling och sallad");
            Console.WriteLine("Vilken pizza får det lov att vara?");
            Console.WriteLine($"[{vesuvio.Number}] {vesuvio.Name}: {vesuvio.Cost}kr: {vesuvio.Description}");
            Console.WriteLine($"[{kebab.Number}] {kebab.Name}: {kebab.Cost}kr: {kebab.Description}");
            Console.WriteLine($"[{kyckling.Number}] {kyckling.Name}: {kyckling.Cost}kr: {kyckling.Description}");

            var userInput = Console.ReadLine();
            if (userInput.ToString() == "1")
            {
                Console.Clear();
                Console.WriteLine($"{vesuvio.Name}, kostar {vesuvio.Cost}");
                Console.WriteLine("Produktbeskrvning:");
                vesuvio.Desc();
                Console.WriteLine("är du säker, Ja/Nej");
                var controlCheck = Console.ReadLine();
                if (controlCheck.ToString().ToLower() == "Ja".ToLower())
                {
                    var checkIfValidPurchase = vesuvio.Cost;
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
                        vesuvio.Buy();
                        vesuvio.Use();
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
                Console.WriteLine($"{kebab.Name}, kostar {kebab.Cost}");
                Console.WriteLine("Produktbeskrvning:");
                kebab.Desc();
                Console.WriteLine("är du säker, Ja/Nej");
                var controlCheck = Console.ReadLine();
                if (controlCheck.ToString().ToLower() == "Ja".ToLower())
                {
                    var checkIfValidPurchase = kebab.Cost;
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
                        kebab.Buy();
                        kebab.Use();
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
                Console.WriteLine($"{kyckling.Name}, kostar {kyckling.Cost}");
                Console.WriteLine("Produktbeskrvning:");
                kyckling.Desc();
                Console.WriteLine("är du säker, Ja/Nej");
                var controlCheck = Console.ReadLine();
                if (controlCheck.ToString().ToLower() == "Ja".ToLower())
                {
                    var checkIfValidPurchase = kyckling.Cost;
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
                        kyckling.Buy();
                        kyckling.Use();
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
        public void MyPizzaList()  //Lista över mina pizza meny
        {
            List<Pizza> list = new List<Pizza>();  
            list.Add(new Pizza(1, "Vesuvio", 65, "Ost och skink pizza"));
            list.Add(new Pizza(2, "Kebab", 85, "Svensk kebabpizza på bästa sätt"));
            list.Add(new Pizza(3, "Kyckling", 75, "underbar kyckling pizza "));
            foreach (Pizza item in list)
            {
                Console.WriteLine("[" + item.Number + "] " + item.Name + "| " + item.Cost + "kr| " + item.Description);
            }

        }
        //IImplementerar metoder från interface 
        public void Desc()
        {
            
            Console.WriteLine("Svenska glutenfria underbarelser du inte behöver mer info om :)");
        }

        public void Use()
        {
            Console.WriteLine("sätter mig och äter min pizza");
        }


        public void Buy()
        {
            
            Console.WriteLine("Betalar för pizzan");
        }
    }
}

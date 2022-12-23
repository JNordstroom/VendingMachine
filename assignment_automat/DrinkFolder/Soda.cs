using assignment_automat.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_automat.DrinkFolder
{
    internal class Soda : Drink, IMachine
    {
        public Soda(int number, string name, int cost, string description) : base(number, name, cost, description)
        {
        }
        public static void SodaImplementation()
        {
            Console.Clear();
            Wallet.CheckSaldo();                                                                    //skapar och visar upp objekt
            Soda Pepsi = new(1, "Pepsi max", 18, "Läsk utan kalorier");
            Soda Coca = new(2, "Coca Cola", 20, "Socker läsk");
            Soda Fanta = new(3, "Fanta", 20, "Sockerläsk");
            Console.WriteLine("Vilken läsk får det lov att vara?");
            Console.WriteLine($"[{Pepsi.Number}] {Pepsi.Name}: {Pepsi.Cost}kr: {Pepsi.Description}");
            Console.WriteLine($"[{Coca.Number}] {Coca.Name}: {Coca.Cost}kr: {Coca.Description}");
            Console.WriteLine($"[{Fanta.Number}] {Fanta.Name}: {Fanta.Cost}kr: {Fanta.Description}");

            var userInput = Console.ReadLine();
            if (userInput.ToString() == "1")
            {
                Console.Clear();
                Console.WriteLine($"{Pepsi.Name}, kostar {Pepsi.Cost}");                            
                Console.WriteLine("Produktbeskrvning:");
                Pepsi.Desc();                                                           //Produkt beskrvning
                Console.WriteLine("är du säker, Ja/Nej");
                var controlCheck = Console.ReadLine();
                if (controlCheck.ToString().ToLower() == "Ja".ToLower())
                {
                    var checkIfValidPurchase = Pepsi.Cost;                  //konto check
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
                        Pepsi.Buy();                                        //köp om konto check går igenom
                        Pepsi.Use();                                        //Använder produkt 
                        Console.ReadLine();
                    }
                }
                else if (controlCheck.ToString().ToLower() == "nej".ToLower())
                {
                    Console.Clear();
                    Console.WriteLine("Du återgår till menyn!");                    //Återgår vid fel val av produkt
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Felaktig inmatning försök igen!");                       //felhantering
                    Console.ReadLine();
                }
            }
            else if (userInput.ToString() == "2")
            {
                Console.Clear();
                Console.WriteLine($"{Coca.Name}, kostar {Coca.Cost}");
                Console.WriteLine("Produktbeskrvning:");
                Coca.Desc();                               //beskrivning                                         
                Console.WriteLine("är du säker, Ja/Nej");
                var controlCheck = Console.ReadLine();
                if (controlCheck.ToString().ToLower() == "Ja".ToLower())        //Kontroll check igen
                {
                    var checkIfValidPurchase = Coca.Cost;
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
                        Coca.Buy();             //köper     
                        Coca.Use();                 //Använder
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
                Console.WriteLine($"{Fanta.Name}, kostar {Fanta.Cost}");
                Console.WriteLine("Produktbeskrvning:");
                Fanta.Desc();           //Beskrivning på produkten
                Console.WriteLine("är du säker, Ja/Nej");
                var controlCheck = Console.ReadLine();
                if (controlCheck.ToString().ToLower() == "Ja".ToLower())
                {
                    var checkIfValidPurchase = Fanta.Cost;
                    if (Wallet.Saldo < checkIfValidPurchase)            //kontroll check
                    {
                        Console.Clear();
                        Console.WriteLine("Du har inte tillräckligt med pengar\ngå till menyn för att lägga in mer!");
                        Console.ReadLine();
                    }
                    else if (Wallet.Saldo >= checkIfValidPurchase)
                    {
                        Console.Clear();
                        Wallet.ReturnFunds(checkIfValidPurchase);           //Drar pengar och genomför köp samt använder produkt
                        Fanta.Buy();
                        Fanta.Use();
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
        public void MySodaList()            //skapar en lista för menyval 
        {
            List<Soda> list = new List<Soda>();
            list.Add(new Soda(1, "Pepsi Max", 18, "Kalorifri kolsyrad läsk"));
            list.Add(new Soda(2, "Coca Cola", 20, "Sockerbomb med söt smak"));
            list.Add(new Soda(3, "Fanta", 20, "Orange dryck med kolsyra"));
            foreach (Soda item in list)
            {
                Console.WriteLine("[" + item.Number + "] " + item.Name + "| " + item.Cost + "kr| " + item.Description);
            }

        }

        public void Buy()
        {
            Console.WriteLine("Du köpte en läskeblask");
        }

        public void Desc()
        {
            Console.WriteLine("Känner du precis som vi att vardagen inte går att vara utan läsk, då har du kommit rätt :)");
        }

        public void Use()
        {
            Console.WriteLine("Vill du öppna din dricka? Ja/nej");
            var use = Console.ReadLine();
            if (use.ToLower() == "Yes".ToLower())
                Console.WriteLine("Knäpper upp och tar sig en sipp");
            else if (use.ToLower() == "Nej".ToLower())
                Console.WriteLine("Lägg ner den i väskan då, UTAN ATT DEN SKAKAS!");
        }
    }
}

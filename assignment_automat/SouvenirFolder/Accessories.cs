using assignment_automat.Category;
using assignment_automat.FoodFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_automat.SouvenirFolder
{
    /*
     * Gör sammanfattning av kommentarerna, 
     * Jag skapar nya objekt för mina olika produkter.
     * Jag skriver ut dem olika produkterna med en foreachloop
     * Användaren gör ett menyval och ges produktinformation.
     * Gör en penga kontroll och har du pengar erbjuds du köpa produkten och använda den
     * annars får du felmeddelande och efterfrågas att lägga in mer pengar.
     */
    internal class Accessories : Souvenir, IMachine
    {
        public Accessories(int number, string name, int cost, string description) : base(number, name, cost, description)
        {
        }
        public static void AccessoriesImplementation()
        {
            Console.Clear();
            Wallet.CheckSaldo();
            Accessories Hatt = new(1, "Hatt", 40, "Sverige hatt");
            Accessories Halsduk = new(2, "Halsduk", 50, "Sverige halsduk");
            Accessories Vantar = new(3, "Vantar", 30, "Sverige handskar");
            Console.WriteLine("Vilken accessoar  får det lov att vara?");
            Console.WriteLine($"[{Hatt.Number}] {Hatt.Name}: {Hatt.Cost}kr: {Hatt.Description}");
            Console.WriteLine($"[{Halsduk.Number}] {Halsduk.Name}: {Halsduk.Cost}kr: {Halsduk.Description}");
            Console.WriteLine($"[{Vantar.Number}] {Vantar.Name}: {Vantar.Cost}kr: {Vantar.Description}");

            var userInput = Console.ReadLine();
            if (userInput.ToString() == "1")
            {
                Console.Clear();
                Console.WriteLine($"{Hatt.Name}, kostar {Hatt.Cost}");
                Console.WriteLine("Produktbeskrvning:");
                Hatt.Desc();
                Console.WriteLine("är du säker, Ja/Nej");
                var controlCheck = Console.ReadLine();
                if (controlCheck.ToString().ToLower() == "Ja".ToLower())
                {
                    var checkIfValidPurchase = Hatt.Cost;
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
                        Hatt.Buy();
                        Hatt.Use();
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
                Console.WriteLine($"{Halsduk.Name}, kostar {Halsduk.Cost}");
                Console.WriteLine("Produktbeskrvning:");
                Halsduk.Desc();
                Console.WriteLine("är du säker, Ja/Nej");
                var controlCheck = Console.ReadLine();
                if (controlCheck.ToString().ToLower() == "Ja".ToLower())
                {
                    var checkIfValidPurchase = Halsduk.Cost;
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
                        Halsduk.Buy();
                        Halsduk.Use();
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
                Console.WriteLine($"{Vantar.Name}, kostar {Vantar.Cost}");
                Console.WriteLine("Produktbeskrvning:");
                Vantar.Desc();
                Console.WriteLine("är du säker, Ja/Nej");
                var controlCheck = Console.ReadLine();
                if (controlCheck.ToString().ToLower() == "Ja".ToLower())
                {
                    var checkIfValidPurchase = Vantar.Cost;
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
                        Vantar.Buy();
                        Vantar.Use();
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

        public static void MyAccessoriesList() //lista över produkter för menyval 
        {
            List<Accessories> list = new List<Accessories>();
            list.Add(new Accessories(1, "Hatt", 45, "Svensk Buckethat "));
            list.Add(new Accessories(2, "Halsduk", 55, "Svensk hallsduk"));
            list.Add(new Accessories(3, "Vantar", 30, "svenska vantar"));
            foreach (Accessories item in list)
            {
                Console.WriteLine("[" + item.Number + "] " + item.Name + "| " + item.Cost + "kr| " + item.Description);
            }

        }
        //implementerar mina olika metoder från interfacet
        public void Buy()
        {
            Console.WriteLine("Jasså ett nytt SVENSKT plagg");
        }

        public void Desc()
        {
            Console.WriteLine("Vad vill du ha mer info om?");
            MyAccessoriesList();
            var userChoice = Console.ReadLine();
            if (userChoice.ToString() == "1".ToString())
                Console.WriteLine("Blågul buckethatt i svensk stil");
            else if (userChoice.ToString() == "2".ToString())
                Console.WriteLine("Tunn dålig halsduk som får dig att ångra köpet :)");
            else if (userChoice.ToString() == "3".ToString())
                Console.WriteLine("Vantar av det varmaste tyget, mysigt");
        }

        public void Use()
        {
            Console.WriteLine("Är det kallt? ja/nej ");
            var eat = Console.ReadLine();
            if (eat.ToLower() == "ja".ToLower())
                Console.WriteLine("Tar på sig sitt plagg");

            else if (eat.ToLower() == "nej".ToLower())
                Console.WriteLine("Låter den ligga i väskan");

        }
    }
}
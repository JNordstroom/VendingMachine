using assignment_automat.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_automat.SouvenirFolder
{
    internal class Souv : Souvenir, IMachine
    {
        
        public Souv(int number, string name, int cost, string description) : base(number, name, cost, description)
        {
        }
        public static void SouvImplementation()
        {
            Console.Clear();
            Wallet.CheckSaldo();
            Souv dala = new(1, "Dalahäst", 33, " En röd trähäst");
            Souv magnet = new(2, "Magnet", 13, "Sverige magnet");
            Souv mugg = new(3, "Mugg", 44, "Sverige mugg");
            Console.WriteLine("Vilken Souvenir får det lov att vara?");
            Console.WriteLine($"[{dala.Number}] {dala.Name}: {dala.Cost}kr: {dala.Description}");
            Console.WriteLine($"[{magnet.Number}] {magnet.Name}: {magnet.Cost}kr: {magnet.Description}");
            Console.WriteLine($"[{mugg.Number}] {mugg.Name}: {mugg.Cost}kr: {mugg.Description}");

            var userInput = Console.ReadLine();
            if (userInput.ToString() == "1")
            {
                Console.Clear();
                Console.WriteLine($"{dala.Name}, kostar {dala.Cost}");
                Console.WriteLine("Produktbeskrvning:");
                dala.Desc();
                Console.WriteLine("är du säker, Ja/Nej");
                var controlCheck = Console.ReadLine();
                if (controlCheck.ToString().ToLower() == "Ja".ToLower())
                {
                    var checkIfValidPurchase = dala.Cost;
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
                        dala.Buy();
                        dala.Use();
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
                Console.WriteLine($"{magnet.Name}, kostar {magnet.Cost}");
                Console.WriteLine("Produktbeskrvning:");
                magnet.Desc();
                Console.WriteLine("är du säker, Ja/Nej");
                var controlCheck = Console.ReadLine();
                if (controlCheck.ToString().ToLower() == "Ja".ToLower())
                {
                    var checkIfValidPurchase = magnet.Cost;
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
                        magnet.Buy();
                        magnet.Use();
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
                Console.WriteLine($"{mugg.Name}, kostar {mugg.Cost}");
                Console.WriteLine("Produktbeskrvning:");
                mugg.Desc();
                Console.WriteLine("är du säker, Ja/Nej");
                var controlCheck = Console.ReadLine();
                if (controlCheck.ToString().ToLower() == "Ja".ToLower())
                {
                    var checkIfValidPurchase = mugg.Cost;
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
                        mugg.Buy();
                        mugg.Use();
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

        public static void MySouvList()
        {
            List<Souv> list = new List<Souv>();
            list.Add(new Souv(1, "Dalahäst", 50, "Traditionell svensk souvenir"));
            list.Add(new Souv(2, "Magnet", 15, "Svensk flagga på en magnet"));
            list.Add(new Souv(3, "Mugg", 30, "Sverige flagga på hela muggen"));
            foreach (Souv item in list)
            {
                Console.WriteLine("[" + item.Number + "] " + item.Name + "| " + item.Cost + "kr| " + item.Description);
            }

        }
        public void Buy()
        {
            Console.WriteLine("Du köpte en souvenir");
        }

        public void Desc()
        {
            Console.WriteLine("Vad vill du ha info om?");
            MySouvList();
            var userChoice = Console.ReadLine();
            if(userChoice.ToString() == "1".ToString())
                Console.WriteLine("En röd traditioell häst som symboliserar Sverige");
            else if(userChoice.ToString() == "2".ToString())
                Console.WriteLine("En totalt värdelös magnet att hänga på ditt kylskåp");
            else if(Console.ReadLine() == "3".ToString())
                Console.WriteLine("En tjock mugg med en liten liten flagga");
        }

        public void Use()
        {
            Console.WriteLine("Lägger sakerna i väskan för det finns INGEN ANVÄNDING AV DEM NU!");

        }
    }
}

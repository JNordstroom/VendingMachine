using assignment_automat.Category;
using assignment_automat.DrinkFolder;
using assignment_automat.FoodFolder;
using assignment_automat.SouvenirFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace assignment_automat
{
    internal class Meny
    {
        public static void Run()
        {
            MyMenu();
        }

        private static void MyMenu()
        {
            //Deklararerar mina nyklar till mina switchcases. 
            ConsoleKeyInfo firstUserInput;
            ConsoleKeyInfo secondUserInput;
            
            
            do
            {
                Console.Clear();
                Wallet.CheckSaldo();                                //Visar saldot
                Console.WriteLine("vad får det lov att vara?");    
                Console.WriteLine("[1] - Mat artiklar");
                Console.WriteLine("[2] - Dryckes artiklar");
                Console.WriteLine("[3] - Souvenir artiklar");
                Console.WriteLine("[4] - Lägg in pengar");
                Console.WriteLine("[5] - Avsluta");

                

                firstUserInput = Console.ReadKey();         //tar första valet användaren väljer.

                switch (firstUserInput.KeyChar.ToString())
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Välj vad du är sugen på!");     
                        Food.FoodList();      //Hämtar objektet med listan över mat.               
                        secondUserInput = Console.ReadKey();    //tar andra valet användaren väljer.
                        bool checkFood = true;                      //Sätter upp en true or false så man kan manipulera när ena caset är klart
                        while(checkFood)
                        {
                            switch (secondUserInput.KeyChar.ToString())
                            {
                                case "1":
                                    Console.Clear();
                                    Pizza.Pizzaimplementation();        //Hämtar min implementation från pizza klassen
                                    checkFood = false;
                                    break;
                                
                                case "2":
                                    Console.Clear();
                                    Sandwich.SandwichImplementation();  //Hämtar min implementation från Sandwich klassen
                                    checkFood = false;

                                    break;

                                case "3":
                                    Console.Clear();
                                    Chips.ChipsImplementation();    //Hämtar min implementation från chips klassen
                                    checkFood = false;
                                    break;
                                
                                default:
                                    Console.WriteLine("felaktig inmatning försök igen!");
                                    Console.ReadLine();
                                    checkFood = false;
                                    break;
                            }
                        } 
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("Välj vad du är sugen på!");
                        Drink.DrinkList();      //Hämtar objektet med listan över drickor.               
                        secondUserInput = Console.ReadKey();    //tar andra valet användaren väljer.
                        bool checkDrink = true;         //Sätter upp en true or false så man kan manipulera när ena caset är klart
                        while (checkDrink)
                        {
                            switch (secondUserInput.KeyChar.ToString())
                            {
                                case "1":
                                    Console.Clear();
                                    Water.WaterImplementation();
                                    checkDrink = false;
                                    break;

                                case "2":
                                    Console.Clear();
                                    Soda.SodaImplementation();
                                    checkDrink = false;

                                    break;

                                case "3":
                                    Console.Clear();
                                    EnergyDrink.EnergyDrinkImplementation();
                                    checkDrink= false;
                                    break;

                                default:
                                    Console.WriteLine("felaktig inmatning försök igen!");
                                    Console.ReadLine();
                                    checkDrink = false;
                                    break;
                            }
                        }
                        break;

                    case "3":
                        Console.Clear();
                        Wallet.CheckSaldo();
                        Console.WriteLine("Något som intresserar dig!");
                        Souvenir.SouvenirList();      //Hämtar objektet med listan över Souvenirer.               
                        secondUserInput = Console.ReadKey();    //tar andra valet användaren väljer.
                        bool checkSouvenir = true;      //Sätter upp en true or false så man kan manipulera när ena caset är klart
                        while (checkSouvenir)
                        {
                            switch (secondUserInput.KeyChar.ToString())
                            {
                                case "1":
                                    Console.Clear();
                                    Accessories.AccessoriesImplementation();
                                    checkSouvenir = false;
                                    break;

                                case "2":
                                    Console.Clear();
                                    
                                    Vykort.VykortImplementation();
                                    checkSouvenir = false;

                                    break;

                                case "3":
                                    Console.Clear();
                                    Souv.SouvImplementation();
                                    checkSouvenir = false;
                                    break;

                                default:
                                    Console.WriteLine("felaktig inmatning försök igen!");
                                    Console.ReadLine();
                                    checkSouvenir= false;
                                    break;
                            }
                        }
                        break;

                    case "4":
                        Console.Clear();
                        Wallet.AddFunds();                  //kallar på metoden för att lägga till pengar
                        break;

                    case "5":
                        Console.Clear();
                        Wallet.MoneyBack();                 // kallar på metoden som returnerar pengar när användaren avslutar
                        Console.WriteLine("Välkommen åter!");
                        break;

                    default:
                        Console.WriteLine("Felaktig inmatning gör om gör rätt");
                        Console.ReadLine();
                        break;
                }


            } while (firstUserInput.KeyChar.ToString() != "5");
        }
        
    }
}

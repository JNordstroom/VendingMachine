using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_automat
{
    internal class Wallet
    {
      //Gör en attribut som kan hålla mitt saldo.  
        public static decimal Saldo { get; set; }

        public Wallet(decimal saldo)
        {
            Saldo = saldo;
        }
        public static void CheckSaldo()
        {
            Console.WriteLine("Nuvarande saldo: " + Saldo);     //Skriver ut det nuvarande saldot
        }
        public static void AddFunds()
        {
            ConsoleKeyInfo key;
            do
            {
                Console.Clear();
                CheckSaldo();
                Console.WriteLine("Lägg in pengar");        //Gör en meny för hur jag ska föra in mynt i maskinen, sparar det till mitt attribut
                Console.WriteLine("[1] - 1kr");
                Console.WriteLine("[2] - 5kr");
                Console.WriteLine("[3] - 10kr");
                Console.WriteLine("[4] - Återvänd till menyn");

                key = Console.ReadKey();
                if (key.KeyChar.ToString() == "1")
                {
                    Saldo += 1;
                }
                else if (key.KeyChar.ToString() == "2")
                {
                    Saldo += 5;
                }
                else if (key.KeyChar.ToString() == "3")
                {
                    Saldo += 10;
                }
            } while (key.KeyChar.ToString() != "4");
               
            
        }
        public static decimal ReturnFunds(decimal funds)
        { 
            
            Saldo -= funds;             //Tar minus på saldot från kostnaden på köpet och returnerar det nya saldot
            return Saldo;
        }
        public static void MoneyBack()
        {
            if(Saldo > 0)                   //Kontrollerar om där finns några pengar kvar och om där finns returnerar jag pengarna vid avslut
            {
                Console.WriteLine("Du får tillbaka " + Saldo + "kr");
            }
            else if (Saldo<= 0)
            {
                Console.WriteLine("Du har inga pengar i maskinen att få tillbaka");
            }

        }
    }
}

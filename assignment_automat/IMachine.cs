using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_automat
{

    //Skapar mina metoder i mitt interface för att senare kunna implementera dem i klasserna
    internal interface IMachine
    {
        public void Desc();
        public void Use();
        public void Buy();

    }
}

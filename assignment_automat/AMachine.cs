using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_automat
{
    internal abstract class AMachine
    {

        //Abstracta klassens properties
        public string Name { get; set; }
        public string Description { get; set; }
        public int Cost { get; set; }
        public int Number { get; set; }

        public AMachine(string name, string description, int cost, int number)
        {
            this.Name = name;
            this.Description = description;
            this.Cost = cost;
            this.Number = number;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class Snacks : Product
    {
        public Snacks(string name, int price) : base(name, price)
        {

        }

        public override void Use()
        {
            // Output string message when product is used
            if (Name == "Chips")
            {
                Console.WriteLine($"{Name} is sooo crunchy!");
            }
            else if (Name == "Peanuts")
            {
                Console.WriteLine($"These {Name} rock!");
            }
            else if (Name == "Pringles")
            {
                Console.WriteLine($"{Name}! Ones you pop, you can't stop!");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class Drinks : Product
    {
        public Drinks(string name, int price) : base(name, price)
        {

        }

        public override void Use()
        {
            // Output string message when product is used
            if (Name == "Coce")
            {
                Console.WriteLine($"{Name} is refreshing!");
            }
            else if (Name == "Pepsi")
            {
                Console.WriteLine($"Diet {Name}...no sugar!");
            }
            else if (Name == "Beer")
            {
                Console.WriteLine($"A {Name} !? I like this Vending Machine!");
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class Fruits : Product
    {
        public Fruits(string name, int price) : base(name, price)
        {

        }

        public override void Use()
        {
            // Output string message when product is purchased and used
            if (Name == "Apple")
            {
                Console.WriteLine($"This {Name} is crunchy!");
            }
            else if (Name == "Pear")
            {
                Console.WriteLine($"This {Name} is sweet!");
            }
            else if (Name == "Orange")
            {
                Console.WriteLine($"This {Name} is jucy!");
            }
        }
    }
}
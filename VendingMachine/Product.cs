using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    abstract class Product
    {
        public Product()
        {

        }
        public Product(string name)
        {
            Name = name;
        }
        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }
        public string Name { get; set; }
        public int Price { get; set; }
      
        public void Examine()
        {
            // Show products price and info
            //Console.WriteLine($"{Name}\t\t{Price}kr");
            Console.WriteLine($"{Name}       \t{Price}kr");
        }

        public virtual void Use()
        {
            // Output string message when product is used
            Console.WriteLine($"{Name} is used!");
        }
    }
}

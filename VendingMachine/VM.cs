using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class VM : IVending
    {

        public readonly int[] MoneyValues = new int[] { 1000, 500, 100, 50, 20, 10, 5, 1 };
        List<Product> Products = new List<Product>();
        List<Product> AllProducts = new List<Product>();
        public int MoneyPool = 0;
        //IVending methods
        public void EndTransaction()
        {
            int calculatedChange = 0;
            int newCalculatedChange = 0;
            calculatedChange = MoneyPool;

            if (MoneyPool == 0)
            {
                Console.WriteLine("No funds in Machine!");
            }
            else
            {
                Console.WriteLine("You receive:");
                foreach (int i in MoneyValues)
                {
                    if (calculatedChange % i < calculatedChange)
                    {
                        int amountOfCoinUnits = calculatedChange / i;
                        newCalculatedChange = calculatedChange % i;
                        calculatedChange = newCalculatedChange;
                        Console.WriteLine($"{amountOfCoinUnits} {i}kr");
                    }

                }
            }
            MoneyPool = 0;
        }

        public int InsertMoney()
        {
            bool input = false;
            int inputSum = 0;
            while (!input)
            {
                
                Console.Write("Insert money to the Vending Machine." +
                "\nValid denomination: [1000, 500, 100, 50, 20, 10, 5, 1]");

                Console.Write("\nYour amount: ");
                input = int.TryParse(Console.ReadLine(), out inputSum);
                if (!input)
                {
                    Console.Clear();
                    Console.WriteLine("The input need to be a number!\n");
                }
                else if (!MoneyValues.Contains(inputSum))
                {
                    Console.Clear();
                    Console.WriteLine("Not a valid denomination!\n");
                    input = false;
                }
                else
                {
                    MoneyPool = IncreaseMoneyPool(inputSum);
                }
            }
            return inputSum;
        }

        public void Purchase()
        {
            PurchaseMenu();
        }

        public int ShowAll()
        {
            
            Console.WriteLine("Vending Machine contains:" +
                "\n------------------------");
            foreach (Product item in AllProducts)
            {
                item.Examine();
            }
            return AllProducts.Count;
        }


        //VM methods

        public int TotalPurchasedItems()
        {
            return Products.Count;
        }
        public void PurchaseMenu()
        {
            var keepAlive = true;
            while (keepAlive)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Choose a category of products: " +
                        "\n------------------------------" +
                        "\n[1]  - Fruits." +
                        "\n[2]  - Snacks." +
                        "\n[3]  - Drinks." +
                        "\n[4]  - Exit to main menu.\n");

                    ShowPurchasedProducts();

                    var choice = int.Parse(Console.ReadLine() ?? "");
                    Console.WriteLine();
                    switch (choice)
                    {
                        case 1: BuyFruit(); break;
                        case 2: BuySnacks(); break;
                        case 3: BuyDrink(); break;
                        case 4:
                            keepAlive = false;
                            break;
                        default:
                            Console.WriteLine("That is not a valid assignment number!");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("That is not a valid number!");
                    //Console.WriteLine(ex);
                    Console.Clear();
                }
            }
        }
        public void BuyFruit()
        {
            Console.Clear();
            Console.WriteLine("Buy: " +
                "\n----" +
                "\n[1] Apple" +
                "\n[2] Orange" +
                "\n[3] Pear");
            bool choice = int.TryParse(Console.ReadLine(), out int result);

            while (choice && result < 4)
            {
                if (result == 1 && MoneyPool >= 27)
                {
                    Product apple = new Fruits("Apple", 27);
                    Products.Add(apple);
                    Console.WriteLine("You bought an Apple for 27kr");
                    MoneyPool = MoneyPool - 27;
                    choice = false;
                }
                else if (result == 2 && MoneyPool >= 28)
                {
                    Product orange = new Fruits("Orange", 28);
                    Products.Add(orange);
                    Console.WriteLine("You bought an Orange for 28kr");
                    MoneyPool = MoneyPool - 28;
                    choice = false;
                }
                else if (result == 3 && MoneyPool >= 29)
                {
                    Product pear = new Fruits("Pear", 29);
                    Products.Add(pear);
                    Console.WriteLine("You bought a Pear for 29kr");
                    MoneyPool = MoneyPool - 29;
                    choice = false;
                }
                else
                {
                    Console.WriteLine("No funds, please insert more money!");
                    choice = false;
                }
                Console.ReadKey();
            }
            
        }
        public void BuySnacks()
        {
            Console.Clear();
            Console.WriteLine("Buy: " +
                "\n----" +
                "\n[1] Chips" +
                "\n[2] Peanuts" +
                "\n[3] Pringles");
            bool choice = int.TryParse(Console.ReadLine(), out int result);

            while (choice && result < 4)
            {
                if (result == 1 && MoneyPool >= 45)
                {
                    Product chips = new Snacks("Chips", 45);
                    Products.Add(chips);
                    Console.WriteLine("You bought Chips for 45kr");
                    MoneyPool = MoneyPool - 45;
                    choice = false;
                }
                else if (result == 2 && MoneyPool >= 32)
                {
                    Product peanuts = new Snacks("Peanuts", 32);
                    Products.Add(peanuts);
                    Console.WriteLine("You bought Peanuts for 32kr");
                    MoneyPool = MoneyPool - 32;
                    choice = false;
                }
                else if (result == 3 && MoneyPool >= 56)
                {
                    Product pringles = new Snacks("Pringles", 56);
                    Products.Add(pringles);
                    Console.WriteLine("You bought Pringles for 56kr");
                    MoneyPool = MoneyPool - 56;
                    choice = false;
                }
                else
                {
                    Console.WriteLine("No funds, please insert more money!");
                    choice = false;
                }
                Console.ReadKey();
            }
        }
        public void BuyDrink()
        {
            Console.Clear();
            Console.WriteLine("Buy: " +
                "\n----" +
                "\n[1] Coce" +
                "\n[2] Pepsi" +
                "\n[3] Beer");
            bool choice = int.TryParse(Console.ReadLine(), out int result);

            while (choice && result < 4)
            {
                if (result == 1 && MoneyPool >= 22)
                {
                    Product coce = new Drinks("Coce", 22);
                    Products.Add(coce);
                    Console.WriteLine("You bought Coce for 22kr");
                    MoneyPool = MoneyPool - 22;
                    choice = false;
                }
                else if (result == 2 && MoneyPool >= 21)
                {
                    Product pepsi = new Drinks("Pepsi", 21);
                    Products.Add(pepsi);
                    Console.WriteLine("You bought Pepsi for 21kr");
                    MoneyPool = MoneyPool - 21;
                    choice = false;
                }
                else if (result == 3 && MoneyPool >= 75)
                {
                    Product beer = new Drinks("Beer", 75);
                    Products.Add(beer);
                    Console.WriteLine("You bought Beer for 75kr");
                    MoneyPool = MoneyPool - 75;
                    choice = false;
                }
                else
                {
                    Console.WriteLine("No funds, please insert more money!");
                    choice = false;
                }
                Console.ReadKey();
            }
        }
        public void UseProducts()
        {
            if (Products.Count == 0)
            {
                Console.WriteLine("You haven't purchased any products yet!");
            }
            else
            {
                foreach (Product item in Products)
                {
                    item.Use();
                }
            }
            Products.Clear();
        }
        public void ShowPurchasedProducts()
        {
            var sum = 0;
            Console.WriteLine("Your basket contains:" +
                "\n---------------------");
            foreach (Product item in Products)
            {
                sum = sum + item.Price;
                item.Examine();
            }
            Console.WriteLine($"\nTotal sum\t{sum}kr");
        }
        public void FillUppVendorMachine()
        {
            //Fill up fruits
            Product fruit = new Fruits("Apple", 27);
            AllProducts.Add(fruit);
            fruit = new Fruits("Orange", 28);
            AllProducts.Add(fruit);
            fruit = new Fruits("Pear", 29);
            AllProducts.Add(fruit);

            //Fill up snacks
            Product snack = new Snacks("Chips", 45);
            AllProducts.Add(snack);
            snack = new Snacks("Peanuts", 32);
            AllProducts.Add(snack);
            snack = new Snacks("Pringles", 56);
            AllProducts.Add(snack);

            //Fill up drinks
            Product drink = new Drinks("Coce", 22);
            AllProducts.Add(drink);
            drink = new Drinks("Pepsi", 21);
            AllProducts.Add(drink);
            drink = new Drinks("Beer", 75);
            AllProducts.Add(drink);

        }
        public int IncreaseMoneyPool(int amount)
        {
            return MoneyPool += amount;
        }
        public bool IsValidDenomination(int prospectDenomination)
        {
            bool validDenimination = false;
            
            foreach (int item in MoneyValues)
            {
                if (item == prospectDenomination)
                {
                    validDenimination = true;
                    break;
                }
            }
            return validDenimination;
        }
    }
}

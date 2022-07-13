﻿using System;
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
        public int MoneyPool = 0;
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
        public int IncreaseMoneyPool(int amount)
        {
            return MoneyPool += amount;
        }

        public void InsertMoney()
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
                    //MoneyPool = MoneyPool + inputSum;
                    MoneyPool = IncreaseMoneyPool(inputSum);
                }
            }
        }

        public void Purchase()
        {
            PurchaseMenu();
        }

        public void ShowAll()
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

//----------------------------------------------------------------------------------------------

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

                    ShowAll();

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
                if (result == 1 && MoneyPool >= 101)
                {
                    Product apple = new Fruits("Apple", 101);
                    Products.Add(apple);
                    Console.WriteLine("You bought an Apple for 101kr");
                    MoneyPool = MoneyPool - 101;
                    choice = false;
                }
                else if (result == 2 && MoneyPool >= 155)
                {
                    Product orange = new Fruits("Orange", 155);
                    Products.Add(orange);
                    Console.WriteLine("You bought an Orange for 155kr");
                    MoneyPool = MoneyPool - 155;
                    choice = false;
                }
                else if (result == 3 && MoneyPool >= 210)
                {
                    Product pear = new Fruits("Pear", 210);
                    Products.Add(pear);
                    Console.WriteLine("You bought a Pear for 210kr");
                    MoneyPool = MoneyPool - 210;
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
            Console.WriteLine("Sorry, this is a healthy Vending Machine. Buy a fruit!");
            Console.ReadKey();
        }
        public void BuyDrink()
        {
            Console.WriteLine("Go get some water from the kitchen, it's free!");
            Console.ReadKey();
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
    }
}

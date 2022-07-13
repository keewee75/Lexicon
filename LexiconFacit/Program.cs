using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace ToB_uppgifter
{
    class Program
    {

        static string path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\text.txt";
        //static string path = AppDomain.CurrentDomain.BaseDirectory + "text.txt";

        static Random rnd = new Random();
        static void Main(string[] args)
        {
            bool isAlive = true;

            while (isAlive)
            {

                Console.WriteLine("Welcome to my project!\n Please select one of the following functionalities: " +
                    "\n 1: Hello world " +
                    "\n 2: User information" +
                    "\n 3: Change color" +
                    "\n 4: Todays date" +
                    "\n 5: Biggest number" +
                    "\n 6: Guess the number" +
                    "\n 7: Save the input to file" +
                    "\n 8: Read text from file" +
                    "\n 9: Mathematical operators" +
                    "\n 10: Multiplication table" +
                    "\n 11: Sort array" +
                    "\n 12: Check if palindrome" +
                    "\n 13: Print out all values between two numbers" +
                    "\n 14: Sort odd/even" +
                    "\n 15: Return sum" +
                    "\n 16: Character creation" +
                    "\n 99: Exit");

                int.TryParse(Console.ReadLine(), out int selection);

                switch (selection)
                {
                    case 1:
                        Console.Clear();
                        HelloWorld();
                        break;
                    case 2:
                        Console.Clear();
                        UserInformation();
                        break;
                    case 3:
                        Console.Clear();
                        ChangeConsoleColor();
                        break;
                    case 4:
                        Console.Clear();
                        TodaysDate();
                        break;
                    case 5:
                        Console.Clear();
                        BiggestNumber();
                        break;
                    case 6:
                        Console.Clear();
                        GuessTheNumber();
                        break;
                    case 7:
                        Console.Clear();
                        PrintToFile();
                        break;
                    case 8:
                        Console.Clear();
                        ReadFromFile();
                        break;
                    case 9:
                        Console.Clear();
                        DecimalHandling();
                        break;
                    case 10:
                        Console.Clear();
                        MultiplicationTable();
                        break;
                    case 11:
                        Console.Clear();
                        SortArray();
                        break;
                    case 12:
                        Console.Clear();
                        CheckIfPalindrome();
                        break;
                    case 13:
                        Console.Clear();
                        PrintNumbersBetween();
                        break;
                    case 14:
                        Console.Clear();
                        SeperateNumbers();
                        break;
                    case 15:
                        Console.Clear();
                        SumOfNumbers();
                        break;
                    case 16:
                        Console.Clear();
                        CharacterCreation();
                        break;
                    case 99:
                        Console.WriteLine("Thank you for trying out my program!");
                        isAlive = false;
                        break;
                    default:
                        Console.WriteLine("Not a valid selection, please try again");
                        break;
                }
                Console.ReadKey();
                Console.Clear();

            }

        }

        private static void HelloWorld()
        {
            Console.WriteLine("Hello world!");
        }
        private static void UserInformation()
        {
            Console.Write("What is your first name? ");
            string fName = Console.ReadLine();
            Console.Write("What is your last name? ");
            string lName = Console.ReadLine();
            Console.Write("What is your age? ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello {0} {1},{2}", fName, lName, age);
            //Console.WriteLine("Hello " + fName + " " + lName + "," + age);

        }
        private static void ChangeConsoleColor()
        {
            if (Console.ForegroundColor == ConsoleColor.Gray)
                Console.ForegroundColor = ConsoleColor.Red;
            else
                Console.ResetColor();


            Console.WriteLine("Text color changed!");
        }
        private static void TodaysDate()
        {
            Console.WriteLine("Todays date is {0:d}!", DateTime.Now);
            //Console.WriteLine("Todays date is {0}!", DateTime.Now.ToShortDateString());
        }
        private static void BiggestNumber()
        {
            Console.Write("Insert a number: ");
            int.TryParse(Console.ReadLine(), out int a);
            Console.Write("Insert another number: ");
            int.TryParse(Console.ReadLine(), out int b);

            if (a > b)
                Console.WriteLine($"{a} is bigger than {b}");
            else if (a < b)
                Console.WriteLine("{0} is bigger than {1}", b, a);
            else
                Console.WriteLine(a + " and " + b + " are equal!");
        }
        private static void GuessTheNumber()
        {
            bool isWrong = true;
            int correctNumber = rnd.Next(1, 101);
            int numberOfGuesses = 0;
            Console.Write("Make a guess of a number between 1 and 100: ");
            int.TryParse(Console.ReadLine(), out int guess);
            while (isWrong)
            {
                numberOfGuesses++;
                if (guess == correctNumber)
                {
                    Console.WriteLine("Your guess of {0} is correct! It took you {1} tries! Good job!", guess, numberOfGuesses);
                    isWrong = false;
                }
                else if (guess > correctNumber)
                {

                    Console.Write("Your guess of {0} is too big! Please try again: ", guess);
                    int.TryParse(Console.ReadLine(), out guess);
                }
                else if (guess < correctNumber)
                {

                    Console.Write("Your guess of {0} is too small! Please try again: ", guess);
                    int.TryParse(Console.ReadLine(), out guess);
                }
            }


        }
        private static void PrintToFile()
        {
            using (StreamWriter outputFile = new StreamWriter(path, true))
            {
                Console.WriteLine("Please input something to save in the file: ");
                outputFile.WriteLine(Console.ReadLine());
                Console.WriteLine($"Input saved to {path}!");
            }


        }
        private static void ReadFromFile()
        {
            using (StreamReader reader = new StreamReader(path))
            {
                Console.WriteLine("---Beginning of file---\n");
                Console.WriteLine(reader.ReadToEnd());
                Console.WriteLine("---End of file---");
            }

        }
        private static void DecimalHandling()
        {
            Console.Write("Please enter a decimal number: ");
            double input = Convert.ToDouble(Console.ReadLine());

            double sqrt = Math.Sqrt(input);
            double pow2 = Math.Pow(input, 2);
            double pow10 = Math.Pow(input, 10);

            Console.WriteLine("Square root: {0} \nPower of 2: {1} \nPower of 10: {2}", sqrt, pow2, pow10);
        }
        private static void MultiplicationTable()
        {
            for (int i = 1; i <= 10; i++)

                Console.Write("\t" + i);


            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("\n");
                Console.Write(i + "\t");
                for (int j = 1; j <= 10; j++)

                    Console.Write(i * j + "\t");

            }
            Console.WriteLine();
        }
        private static void SortArray()
        {
            int[] rndArr = new int[10];
            int[] sortedArr = new int[rndArr.Length];

            for (int i = 0; i < rndArr.Length; i++)
            {
                rndArr[i] = rnd.Next(1, 201);
            }

            Console.WriteLine("Random array: ");
            foreach (var item in rndArr)
            {
                Console.Write(item + " ");
            }
            int temp = 0;

            for (int write = 0; write < rndArr.Length; write++)
            {
                for (int sort = 0; sort < rndArr.Length - 1; sort++)
                {
                    if (rndArr[sort] > rndArr[sort + 1])
                    {
                        temp = rndArr[sort + 1];
                        rndArr[sort + 1] = rndArr[sort];
                        rndArr[sort] = temp;
                    }
                }
            }


            for (int i = 0; i < rndArr.Length; i++)
            {
                sortedArr[i] = rndArr[i];
            }

            Console.WriteLine("\nSorted array:");
            foreach (var item in sortedArr)
            {
                Console.Write(item + " ");
            }




        }
        private static void CheckIfPalindrome()
        {
            Console.WriteLine("Please input a word (or a sentence) to check if it is a palindrome: ");
            string input = Console.ReadLine();

            char[] inputArr = input.ToCharArray();

            Array.Reverse(inputArr);

            string reverse = new string(inputArr);

            if (reverse.Equals(input, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine($"{input} is a palindrome!");
            else
                Console.WriteLine("{0} is NOT a palindrome!", input);

        }
        private static void PrintNumbersBetween()
        {
            Console.Write("Please input a number: ");
            int.TryParse(Console.ReadLine(), out int a);
            Console.Write("Please input another number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a < b)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(a);
                Console.ForegroundColor = ConsoleColor.Gray;
                for (int i = a + 1; i < b; i++)
                {
                    Console.Write(" " + i);
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" " + b);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else if (a > b)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(b);
                Console.ForegroundColor = ConsoleColor.Gray;
                for (int i = b + 1; i < a; i++)
                {
                    Console.Write(" " + i);
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" " + a);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
                Console.WriteLine("The numbers are identical!");

        }
        private static void SeperateNumbers()
        {
            Console.Write("Insert numbers seperated by ',': ");
            List<int> evenNumbers = new List<int>();
            List<int> oddNumbers = new List<int>();
            List<int> input = Console.ReadLine().Split(',').Select(int.Parse).ToList();

            foreach (var item in input)
            {
                if (item % 2 == 0)
                    evenNumbers.Add(item);
                else
                    oddNumbers.Add(item);
            }

            Console.Write("Even numbers: ");
            foreach (var item in evenNumbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n---------------------------");
            Console.Write("Odd numbers: ");
            foreach (var item in oddNumbers)
            {
                Console.Write(item + " ");
            }
        }
        private static void SumOfNumbers()
        {
            Console.Write("Insert numbers seperated by ',': ");
            List<int> input = Console.ReadLine().Split(',').Select(int.Parse).ToList();

            Console.WriteLine($"Total value of input: {input.Sum()}");

        }
        private static void CharacterCreation()
        {
            Character player = new Character();
            Character enemy = new Character();

            Console.Write("Please enter your name: ");
            player.Name = Console.ReadLine();
            player.Health = rnd.Next(1, 26);
            player.Strength = rnd.Next(1, 11);
            player.Luck = rnd.Next(0, 51);

            Console.Write("Please enter the name of your enemy: ");
            enemy.Name = Console.ReadLine();
            enemy.Health = rnd.Next(1, 26);
            enemy.Strength = rnd.Next(1, 11);
            enemy.Luck = rnd.Next(0, 51);
            Console.Clear();
            Console.WriteLine("---Player---" +
                $"\nName: {player.Name}" +
                $"\nHealth: {player.Health}" +
                $"\nStrength: {player.Strength}" +
                $"\nLuck: {player.Luck}\n");

            Console.WriteLine("---Enemy---" +
               $"\nName: {enemy.Name}" +
               $"\nHealth: {enemy.Health}" +
               $"\nStrength: {enemy.Strength}" +
               $"\nLuck: {enemy.Luck}");


        }


    }
    class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }
        public int Luck { get; set; }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraExercises
{
    internal class Exercises
    {
        public Random rnd { get; set; } = new Random();
        public void RunExerciseOne()
        {
            string firstName = "Marko";
            string lastName = "Kivi";
            Console.WriteLine($"Hello {firstName} {lastName}, this was your first assignment!");
        }

        public void RunExerciseTwo()
        {
            var todaysDate = DateTime.Today;
            var tomorrowsDate = DateTime.Today.AddDays(1);
            var yesterdaysDate = DateTime.Today.AddDays(-1);

            Console.WriteLine($"Todays date is {todaysDate.ToString("d")}" +
                $"\nTomorrows date is {tomorrowsDate.ToString("d")}" +
                $"\nYesterdays date was {yesterdaysDate.ToString("d")}"
                );
        }

        public void RunExerciseThree()
        {
            Console.Write("Enter your First Name: ");
            string? firstName = Console.ReadLine();
            Console.Write("Enter your Last Name: ");
            string? flastName = Console.ReadLine();
            Console.WriteLine($"\nHello {firstName} {flastName} !");
        }

        public void RunExerciseFour()
        {
            // Replace "The quick fox Jumped Over the DOG" with: "The brown fox jumped over the lazy dog"

            string orgStr = "The quick fox Jumped Over the DOG";
            string newStr = orgStr.ToLower();
            string firstLetter = newStr.Substring(0, 1).ToUpper();
            newStr = firstLetter + newStr.Substring(1);
            newStr = newStr.Replace("quick", "brown").Insert(30, "lazy ");

            Console.WriteLine($"Old string: \"{orgStr}\"");
            Console.WriteLine($"New string: \"{newStr}\"");
        }

        public void RunExerciseFive()
        {
            // Store [1,2,3,4,5] to a new string
            // remove values 2 and 3
            // insert 6-10
            // comma separated
            // output [1,4,5,6,7,8,9,10]

            string str = "Arrays are very common in programming,they look something like: [1,2,3,4,5]";
            string newStr = str.Substring(64);
            newStr = newStr.Replace(",2", "").Replace(",3", "");
            newStr = newStr.Insert(6, ",6,7,8,9,10");
            Console.WriteLine(newStr);
        }

        public void RunExerciseSix()
        {
            // Insert two integers
            // Output biggest, smallest and +-*/

            Console.Write("Insert first integer: ");
            int firstInt = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insert second integer: ");
            int secondInt = Convert.ToInt32(Console.ReadLine());
            double divided = Convert.ToDouble(firstInt) / Convert.ToDouble(secondInt);

            Console.Write($"Biggest number is: " + Math.Max(firstInt, secondInt) +
                $"\nSmallest number is: " + Math.Min(firstInt, secondInt) +
                $"\n{firstInt} + {secondInt} = " + (firstInt + secondInt) +
                $"\n{firstInt} - {secondInt} = " + (firstInt - secondInt) +
                $"\n{firstInt} * {secondInt} = " + (firstInt * secondInt) +
                $"\n{firstInt} / {secondInt} = "
                );
            if (secondInt == 0)
            {
                Console.Write($"You cannot divide by {secondInt}\n");
            }
            else
            {
                Console.Write("{0:0.000}\n", divided);
            }
        }

        public void RunExerciseSeven()
        {
            // Insert radious as a double
            // calculate area of circle
            // calculate area and volume of sphere

            Console.Write("Insert a radious value: ");
            double radious = Convert.ToDouble(Console.ReadLine());

            double pi = Math.PI;
            double areaCircle = pi * radious * radious;
            double areaSphere = 4 * pi * (radious * radious);
            double volumeSphere = 4 / 3 * pi * (radious * radious * radious);

            Console.WriteLine($"\nThe area of the circle is: " + areaCircle +
                $"\nThe area of the sphere is: " + areaSphere +
                $"\nThe volume of the sphere is: " + volumeSphere
                );
        }

        public void RunExerciseEight()
        {
            // Insert decimal number
            // Output square root and number raised to the power of 2 and 10

            Console.Write("Insert decimal number: ");
            decimal decimalNumber = Convert.ToDecimal(Console.ReadLine());

            double sqrt = Math.Sqrt(Convert.ToDouble(decimalNumber));
            Convert.ToDecimal(sqrt);
            double pow2 = Math.Pow(Convert.ToDouble(decimalNumber), 2);
            Convert.ToDecimal(pow2);
            double pow10 = Math.Pow(Convert.ToDouble(decimalNumber), 10);
            Convert.ToDecimal(pow10);

            Console.WriteLine($"\n Sqrt = " + sqrt +
                $"\n Pow2 = " + pow2 +
                $"\n Pow10 = " + pow10
                );
        }

        public void RunExerciseNine()
        {
            // Ask for name and save to a variable
            // Greet user and ask for his birth year and convert to integer
            // Calculate age

            Console.Write("Hi, what's your name?: ");
            string name = Console.ReadLine();
            Console.Write($"Hello {name}, what's your birth year?: ");
            int birthYear = Convert.ToInt32(Console.ReadLine());
            int age = DateTime.Now.Year - birthYear;
            Console.WriteLine($"{name} is {age} years old.");

            if (age >= 18)
            {
                Console.Write($"Do you want to order a beer, Y/N ? :");
                char yesOrNo = Convert.ToChar(Console.ReadLine().ToUpper());
                if (yesOrNo == 'Y')
                {
                    Console.WriteLine("Here you go, a pint of beer!");
                }
                else if (yesOrNo == 'N')
                {
                    Console.Write("Do you want to order a coke, Y/N ? :");
                    yesOrNo = Convert.ToChar(Console.ReadLine().ToUpper());
                    if (yesOrNo == 'Y')
                    {
                        Console.WriteLine("Here you go, a cold coce!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, we don't serve anything else.");
                    }
                }
            }
            else
            {
                Console.Write("Do you want to order a coke, Y/N ? :");
                char yesOrno = Convert.ToChar(Console.ReadLine().ToUpper());
                if (yesOrno == 'Y')
                {
                    Console.WriteLine("Here you go, a cold coce!");
                }
                else
                {
                    Console.WriteLine("Sorry, we don't serve anything else.");
                }
            }
        }

        public void RunExerciseTen()
        {
            // Choose between 3 different options using switch-statement
            // 1. invoke method that let user input two numbers (a and b). b cannot be zero. a divided by b. if b zero display error.
            // 2. invoke method from exercise 4
            // 3. toggle foreground color between two colors. use if-statement to check current color.

            Console.WriteLine("Choose one option between 1 and 3: ");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    DivideTwoNumbers();
                    break;
                case 2:
                    RunExerciseFour();
                    break;
                case 3:
                    if (Console.ForegroundColor == ConsoleColor.Green)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ResetColor();
                    }
                    Console.WriteLine("Text color changed!");
                    break;
            }
        }

        public void RunExerciseEleven()
        {
            // Input integer. If <= 0 display error
            // two for-loops. first counts from zero to given number. second counts from given number to zero.
            // both loops checks for evenly divisible by 2. change color between red and green.

            Console.Write("Enter a number above zero: ");
            int input = Convert.ToInt32(Console.ReadLine());

            while (input <= 0)
            {
                Console.WriteLine("The number is not above zero, try again: ");
                input = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i <= input; i++)
            {
                if (i % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(i);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(i);
                }

            }
            Console.WriteLine("-----------------------------");

            for (int i = input; i >= 0; i--)
            {
                if (i % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(i);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(i);
                }

            }

        }

        public void RunExerciseTwelve()
        {
            // Output multiplication table for 1 to 10 using nested for-loops

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("\n");
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(i * j + "\t");
                }
            }
            Console.WriteLine("\n");
        }

        public void RunExerciseThirteen()
        {
            // User guesses a random number between 1-500. Store in variable
            // Display if guess is greater or smaller and keep counting
            // Keep executing untill correct guess

            bool isWrong = true;
            int correctNumber = this.rnd.Next(1, 500);
            int numberOfGuesses = 0;
            Console.Write("Make a guess of a number between 1 and 500: ");
            int.TryParse(Console.ReadLine(), out int guess);
            while (isWrong)
            {
                numberOfGuesses++;
                if (guess == correctNumber)
                {
                    Console.WriteLine($"Your guess of {guess} is correct! It took you {numberOfGuesses} tries!");
                    isWrong = false;
                }
                else if (guess > correctNumber)
                {
                    Console.Write($"Your guess of {guess} is too big. Please try again: ");
                    int.TryParse(Console.ReadLine(), out guess);
                }
                else if (guess < correctNumber)
                {
                    Console.Write($"Your guess of {guess} is too small. Please try again: ");
                    int.TryParse(Console.ReadLine(), out guess);
                }
            }
        }

        public void RunExerciseFourteen()
        {
            // Input and store numbers until he enters -1
            // Display sum and average

            bool isTrue = true;
            int number = 0;
            List<int> numbers = new List<int>();

            Console.WriteLine("Enter numbers, when ready enter -1\n");

            while (isTrue)
            {
                Console.Write("Enter a number: ");
                int.TryParse(Console.ReadLine(), out number);

                if (number != -1)
                {
                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine($"Sum = {numbers.Sum()}");
                    Console.WriteLine($"Average = {numbers.Average()}");
                    isTrue = false;
                }
            }
        }

        public void RunExerciseFifteen()
        {
            // Ask for a number.
            // Display all numbers that the number is divisible by.
            // Use modulo and loop
            int number = 0;
            Console.Write("Enter a number: ");
            int.TryParse(Console.ReadLine(), out number);

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine($"{i} is divisible by {number}");
                }
            }
            // Display the 3 first perfect numbers

            Console.WriteLine("\n---------------------------------\n");
            Console.WriteLine("Output the 3 perfect numbers:");
            int count = 0;
            for (int x = 1; x < int.MaxValue; x++)
            {
                if (IsPerfect(x))
                {
                    Console.WriteLine(x + " is perfect.");
                    count++;
                }
                if (count == 3)
                    break;

            }

            static bool IsPerfect(int num)
            {
                int sum = 0;
                for (int i = 1; i < num; i++)
                {
                    if (num % i == 0)
                        sum += i;
                }
                return sum == num;
            }
        }

        public void RunExerciseSixteen()
        {
            // Input a number.
            // Use this number to output the Fibonacci series up until that number.
            bool input = false;
            int fibLenght = 0, a = 0, b = 1, c = 0;

            while (!input)
            {
                Console.Write("Enter the length of the Fibonacci series: ");
                input = int.TryParse(Console.ReadLine(), out fibLenght);
                if (!input)
                {
                    Console.WriteLine("The input need to be a number!");
                }
            }

            Console.Write($"{a} {b}");
            for (int i = 2; i < fibLenght; i++)
            {
                c = a + b;
                Console.Write($" {c}");
                a = b;
                b = c;
            }
            Console.WriteLine("\n");
        }

        public void RunExerciseSeventeen()
        {
            // Input a string and check if the word or sentence is a palindrome
            // Use some string manipulation to remove spaces (I used Linq: https://kodify.net/csharp/strings/remove-whitespace/)

            Console.WriteLine("Input a word or sentence to check if it is a palindrome: ");
            string input = Console.ReadLine();
            string inputWithoutSpaces = string.Concat(input.Where(c => !char.IsWhiteSpace(c)));
            char[] inputArr = inputWithoutSpaces.ToCharArray();
            Array.Reverse(inputArr);
            string reverse = new string(inputArr);

            if (reverse.Equals(inputWithoutSpaces, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"{input} is a palindrome!");
            }
            else
            {
                Console.WriteLine($"{input} is NOT a palindrome!");
            }
        }

        public void RunExerciseEighteen()
        {
            // Create an int Array and double Array. 10 elemenst in both. Assign random values to int Array.
            // Loop through double Array and assign values from int Array to same position, also divide value by 1.
            // Output values from both Arrays with foreach-loop.

            int[] intArray = new int[10];
            double[] doubleArray = new double[10];

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = rnd.Next(1, 100);
            }

            for (int i = 0; i < doubleArray.Length; i++)
            {
                doubleArray[i] = intArray[i];
                doubleArray[i] = 1 / doubleArray[i];
            }

            Console.WriteLine("Random values between 1-100:");
            foreach (int i in intArray)
            {
                Console.WriteLine($"{i} ");
            }
            Console.WriteLine();

            Console.WriteLine("1 divided by the above value:");
            //int count = 0;
            foreach (double d in doubleArray)
            {
                Console.WriteLine("1 / {0} = {1:0.000}", intArray[Array.IndexOf(doubleArray, d)], d);
                //Console.Write($"1 / {intArray[count]} \t=  ");
                //Console.WriteLine($"{d} ");
                //count++;
            }
            Console.WriteLine();
        }

        public void RunExerciseNineteen()
        {
            // Output random price.
            // Input the sum user hands the cashier.
            // Calculate the change that the user should get back in different coin unit.
            // The goal is to get as few coins as possible.
            // Use Array to store different coin units. Use integer division and modulus.

            bool input = false;
            int[] coinUnits = { 1000, 500, 100, 50, 20, 10, 5, 1 };
            int price = rnd.Next(10, 5000);
            int inputSum = 0;
            int calculatedChange = 0;
            int newCalculatedChange = 0;
            Console.Write($"Money to pay: {price}\n");

            while (!input)
            {
                Console.Write("Enter the sum to pay: ");
                input = int.TryParse(Console.ReadLine(), out inputSum);
                if (!input)
                {
                    Console.WriteLine("The input need to be a number!");
                }
            }

            Console.Write($"Sum to pay: {inputSum}\n");
            Console.WriteLine($"Calculated change: {calculatedChange = inputSum - price}");
            Console.WriteLine("Coins distribution:");

            foreach (int i in coinUnits)
            {
                if (calculatedChange % i == calculatedChange)
                {
                    Console.WriteLine($"{i} coins = 0");
                }
                else if (calculatedChange % i < calculatedChange)
                {
                    int amountOfCoinUnits = calculatedChange / i;
                    newCalculatedChange = calculatedChange % i;
                    calculatedChange = newCalculatedChange;
                    Console.WriteLine($"{i} coins = {amountOfCoinUnits}");
                }

            }
        }

        public void RunExerciseTwenty()
        {
            // Create two random sized arrays and fill one with random numbers.
            // Copy random numbers to the second array.
            // Even numbers located to the right, and odd numbers to the left.

            int randomArraySize = rnd.Next(10, 20);
            int[] arrayOne = new int[randomArraySize];
            int[] arrayTwo = new int[randomArraySize];

            int indexLeft = 0; // Start point of Array index from left
            int indexRight = arrayOne.Length - 1; // Start point of Array index from right

            Console.WriteLine("Array 1 (random size) filled with random numbers:");
            for (int i = 0; i < arrayOne.Length; i++)
            {
                arrayOne[i] = rnd.Next(1, 100);
                Console.Write($"{arrayOne[i]} ");
            }

            foreach (int number in arrayOne)
            {
                if ((number % 2) == 0)
                {
                    arrayTwo[indexRight] = number;
                    indexRight--;
                }
                else
                {
                    arrayTwo[indexLeft] = number;
                    indexLeft++;
                }
            }

            Console.WriteLine($"\n\nFound {indexLeft} odd numbers and {arrayTwo.Length - indexLeft} even numbers.\n");
            Array.Sort(arrayTwo, 0, indexLeft);
            Array.Sort(arrayTwo, indexLeft, arrayTwo.Length - indexLeft);

            Console.Write("Numbers copied to Array 2 and sorted ");
            Console.ForegroundColor = ConsoleColor.Red; Console.Write("odd");
            Console.ForegroundColor = ConsoleColor.Green; Console.Write("/even:\n");
            foreach (int number in arrayTwo)
            {
                if (number % 2 != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{number} ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{number} ");
                }
            }
            Console.WriteLine("\n");
        }

        public void RunExerciseTwentyOne()
        {
            // Input numbers comma separated ex. "1,2,56,43,8,12"
            // Separate numbers in the string into an array
            // find min, max and average value

            Console.Write("Input numbers separated by ',': ");
            string numbersInput = Console.ReadLine();
            string[] numbersStringArray = numbersInput.Split(',').ToArray();
            int[] numbersIntArray = new int[numbersStringArray.Length];

            int indexCount = 0;
            foreach (string number in numbersStringArray)
            {
                numbersIntArray[indexCount] = Convert.ToInt32(number);
                indexCount++;
            }
            Console.WriteLine($"Min = {numbersIntArray.Min()} \nMax = {numbersIntArray.Max()} \nAverage = {numbersIntArray.Sum() / numbersIntArray.Length}");
        }

        public void RunExerciseTwentyTwo()
        {
            // Ask user to input some text
            // Check for all swear words
            // Store swear words in an Array
            // Check textual input against the Array and use string manipulation to replace swear words

            string[] swearWords = new string[] { "hell", "freaking", "bad", "damn" };
            string[] niceWords = new string[] { "heaven", "jolly", "good", "gosh" };
            //string myText = "Hell is a freaking bad word, damn damn";
            Console.WriteLine("Enter some text:");
            string myText = Console.ReadLine();
            string[] myTextArray = myText.Split(' ').ToArray();
            Console.WriteLine(myText + "\n");
            //Console.WriteLine("Please enter some text:");
            //StringBuilder textInput = new StringBuilder(Console.ReadLine());
            //Console.WriteLine(textInput.ToString());
            int indexLenght = 0;
            foreach (string word in swearWords)
            {
                if (myText.Contains(word))
                {
                    indexLenght++;
                }
            }
            string[] swearWordsFromMyText = new string[indexLenght];

            Console.Write("Uggly words found:");
            int indexCount = 0;
            foreach (string word in swearWords)
            {
                if (myText.Contains(word))
                {
                    swearWordsFromMyText[indexCount] = word;
                    indexCount++;
                    Console.Write($" '{word}' ");
                }

            }

            int indexCount2 = 0;
            foreach (string word in swearWords)
            {
                myText = myText.Replace(word, niceWords[indexCount2]);
                indexCount2++;
            }
            Console.WriteLine($"\n\nConverted text to: '{myText}'\n");
        }

        public void RunExerciseTwentyThree()
        {
            // Generate 7 unice numbers between 1-40
            // Each number may only appear once in the array.
            // Use Random-class to generate numbers, and they should be different each time you run the program.

            List<int> numbers = new();

            for (int i = 1; i <= 40; i++)
            {
                numbers.Add(i);
            }

            for (int i = 0; i < 7; i++)
            {
                int index = rnd.Next(numbers.Count);
                Console.Write(numbers[index] + " ");

                numbers.RemoveAt(index);
            }
            Console.WriteLine("\n");
        }

        public void RunExerciseTwentyFour()
        {
            int[] startDeck = new[] { 1,1,1,1,2,2,2,2,3,3,3,3,4,4,4,4,5,5,5,5,6,6,6,6,7,7,7,7,8,8,8,8,9,9,9,9,10,10,10,10,11,11,11,11,12,12,12,12,13,13,13,13 };
            int i = 0, x = 0;
            //int[] startDeck = new[] {2,4,6,8,10,12,14};
            int[] drawnCards = new int[x];
            
            Console.Write($"Your starting deck: ");
            foreach (int card in startDeck)
            {
                Console.Write($"{card} ");
            }
            Console.WriteLine("\n");
            bool IsAlive = true;
            while (IsAlive)
            {
                Console.WriteLine("Press ENTER to Shuffle and draw a card. [Q] to quit");
                char chr = Console.ReadKey().KeyChar;
                chr = char.ToLower(chr);
                Console.Clear();
                if (chr != 'q')
                {
                    Console.Write("Remaining cards in deck: ");
                    ShuffleCards(ref startDeck);
                    int drawnCard = DrawCard(ref startDeck);
                    drawnCards = drawnCards.Append(drawnCard).ToArray();
                    
                    //startDeck = startDeck.Where((source, index) => index != startDeck.Length - 1).ToArray(); // Another way to Resize Array
                    Array.Resize(ref startDeck, startDeck.Length - 1);

                    foreach (int card in startDeck)
                    {
                        Console.Write($"{card} ");
                    }

                    Console.Write("\nDrawn cards: ");
                    foreach (int card in drawnCards)
                    {
                        Console.Write($"{card} ");
                    }
                    Console.WriteLine("\n");
      
                    static int DrawCard(ref int[] deck)
                    {
                        int card = deck[deck.Length - 1];
                        return card;
                    }

                    static void ShuffleCards(ref int[] deck)
                    {
                        int[] temp = deck.OrderBy(n => Guid.NewGuid()).ToArray();
                        Array.Copy(temp, 0, deck, 0, temp.Length);
                        
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Thanks for playing");
                    IsAlive = false;
                }
            }   
        }

        public void RunExerciseTwentyFive()
        {
            Console.WriteLine(InputNumber());
        }

        /* -------------------------------------------------------------------
         * ------------------------------------------------------------------- */
        // Method for Exercise 10: Divide two numbers.
        public void DivideTwoNumbers()
        {
            Console.Write("Input your first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input your second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (b == 0)
            {
                Console.WriteLine("You cannot divide by 0");
            }
            else
            {
                double result = Convert.ToDouble(a) / Convert.ToDouble(b);
                Console.WriteLine($"{a} / {b} = {result}");
            }
        }

        // Method for Exercise 25: Input number. Use Try-cath. Error handling
        public static int InputNumber()
        {
            bool wrongFormat = true;
            int numberInput = 0;
            while (wrongFormat)
            {   
                try
                {
                    Console.Write("Input a number: ");
                    numberInput = int.Parse(Console.ReadLine());
                    //wrongFormat = false;
                    return numberInput;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    //return 0;
                }               
            }
            return numberInput;
        }
    }
}

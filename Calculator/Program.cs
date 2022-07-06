// Week 1. Assignment 1 = Create a basic calculator that handle +-*/
// Program should be running until user chooses to end it.
// Each mathematical operation in its own methods.
// Division should inform the user if they try to divide by zero.
// Week 3. Add overload to - and + that takes an array as input parameter.
// xUnit test each mathematical operations and dividing with zero.
// Handle exceptions, like in user inputs.

using Calculator;
bool endApp = true;
while (endApp)
{
    Console.WriteLine("Menu options :");
    Console.WriteLine("--------------\n");

    Console.WriteLine("(1) Use simple Calculator." +
        "\n(2) Add several numbers." +
        "\n(3) Subtract several numbers." +
        "\n(9) End program!"
        );

    Console.Write("\nEnter option number: ");

    int.TryParse(Console.ReadLine(), out int selection);

    switch (selection)
    {
        case 1:
            Calculator();
            break;
        case 2:
            AddSeveralNumbers();
            break;
        case 3:
            SubtractSeveralNumbers();
            break;
        case 9:
            Console.WriteLine("Bye bye!");
            endApp = false;
            break;
        default:
            Console.WriteLine("Not a valid option, try again");
            break;
    }
    Console.ReadKey();
    Console.Clear();
}

static void Calculator()
{
    Console.Write("\nType your first value: ");
    double numInput1 = ToNumber(Console.ReadLine());

    Console.WriteLine("\nChoose an operator from the following list: " +
    "\n\ta - Add" +
    "\n\ts - Subtract" +
    "\n\tm - Multiply" +
    "\n\td - Divide");
    Console.Write("\nYour option? : ");
    string op = Console.ReadLine().ToLower();

    // While loop to check correct operator
    string asmd = "asmd";
    while (!asmd.Contains(op))
    {
        Console.Write("Incorrect option, please choose operator from the list: ");
        op = Console.ReadLine();
    }

    Console.Write("\nType your second value: ");
    double numInput2 = ToNumber(Console.ReadLine());

    if (op == "a")
    {
        double result = MathOperations.Addition(numInput1, numInput2);
        Console.WriteLine($"{numInput1} + {numInput2} = {result}");
    }
    else if (op == "s")
    {
        double result = MathOperations.Subtraction(numInput1, numInput2);
        Console.WriteLine($"{numInput1} - {numInput2} = {result}");
    }
    else if (op == "m")
    {
        double result = MathOperations.Multiplication(numInput1, numInput2);
        Console.WriteLine($"{numInput1} * {numInput2} = {result}");
    }
    else if (op == "d")
    {
        if (numInput2 == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You cannot divide by 0");
            Console.ResetColor();
        }
        else
        {
            double result = MathOperations.Division(numInput1, numInput2);
            Console.WriteLine($"{numInput1} / {numInput2} = {result}");
        }
    }

    // Method: Check and convert string to number (double)
    static double ToNumber(string input)
    {
        double num;
        while (!double.TryParse(input, out num))
        {
            Console.Write("Please input a number: ");
            input = Console.ReadLine();
        }
        return num;
    }
}
static void AddSeveralNumbers()
{
    double[] userInputToAdd = UserInputArray();
    double sumAddition = MathOperations.Addition(userInputToAdd);

    Console.WriteLine(sumAddition);
}
static void SubtractSeveralNumbers()
{
    double[] userInputToSubtract = UserInputArray();
    double sumSubtract = MathOperations.Subtraction(userInputToSubtract);

    Console.WriteLine(sumSubtract);
}
static double[] UserInputArray()
{
    List<double> numberInputList = new List<double>();
    bool wrongFormat = false;

    while (wrongFormat == false)
    {
        try
        {
            Console.WriteLine("\nInsert numbers separated by ',': ");
            numberInputList = Console.ReadLine().Split(',').Select(double.Parse).ToList();
        }
        catch (Exception ex)
        {
            Console.Write(ex.Message);
            wrongFormat = true;
        }
        if (wrongFormat == true)
        {
            wrongFormat = false;
        }
        else
        {
            break;
        }
    }

    double[] numArray = new double[numberInputList.Count];
    int arrayIndex = 0;
    foreach (double number in numberInputList)
    {
        numArray[arrayIndex] = number;
        arrayIndex++;
    }
    return numArray;
}
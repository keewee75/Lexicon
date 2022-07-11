var keepAlive = true;
while (keepAlive)
{
    try
    {
        Console.WriteLine("Enter your choice: " +
            "\n[ 1 ] - Insert money" +
            "\n[ 2 ] - Buy a Snickers.  200kr each." +
            "\n[ 3 ] - Buy a Bounty.    150kr each." +
            "\n[ 4 ] - Buy a Twix.      50kr each." +
            "\n[ 5 ] - Five" +
            "\n[ -1 ] - Exit");
        var choice = int.Parse(Console.ReadLine() ?? "");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        switch (choice)
        {
            case 1: Console.WriteLine("One"); break;
            case 2: Console.WriteLine("two"); break;
            case 3: Console.WriteLine("three"); break;
            case 4: Console.WriteLine("four"); break;
            case 5: Console.WriteLine("five"); break;
            case 6: Console.WriteLine("six"); break;
            case 7: Console.WriteLine("seven"); break;
            case 8: Console.WriteLine("eight"); break;
            case -1:
                keepAlive = false;
                break;
            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("That is not a valid assignment number!");
                break;
        }
        Console.ResetColor();
        Console.WriteLine("Hit any key to continue!");
        Console.ReadKey();
        Console.Clear();
    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("That is not a valid number!");
        Console.WriteLine(ex);
        Console.ResetColor();
    }
}
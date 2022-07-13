using VendingMachine;

var keepAlive = true;

VM vm = new VM();

while (keepAlive)
{
    try
    {
        Console.Write("Vending machine options:         [current saldo ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write($"{vm.MoneyPool}");
        Console.ResetColor();
        Console.Write(" kr]" +
            "\n------------------------" +
        "\n[1]  - Insert money." +
            "\n[2]  - Buy a product." +
            "\n[3]  - Show all products." +
            "\n[4]  - End Transaction." +
            "\n[5]  - Use products." +
            "\n[6]  - Exit." +
            "\nEnter your choice: ");
        var choice = int.Parse(Console.ReadLine() ?? "");
        Console.WriteLine();
        //Console.ForegroundColor = ConsoleColor.Green;
        switch (choice)
        {
            case 1: vm.InsertMoney(); Console.Clear(); break;
            case 2: vm.Purchase(); Console.Clear(); break;
            case 3: vm.ShowAll(); Console.ReadKey();  Console.Clear(); break;
            case 4: vm.EndTransaction(); Console.ReadKey(); Console.Clear(); break;
            case 5: vm.UseProducts(); Console.ReadKey(); Console.Clear(); break;
            case 6:
                keepAlive = false;
                break;
            default:
                //Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("That is not a valid assignment number!");
                Console.ReadKey();
                Console.Clear();
                break;
        }
    }
    catch (FormatException ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("That is not a valid number!");
        //Console.WriteLine(ex);
        Console.ResetColor();
        Console.Clear();
    }
}
// Extra exercises - Lexicon

using ExtraExercises;

var keepAlive = true;
while (keepAlive)
{
    try
    {
        Console.Write("Enter assignment number (or -1 to exit): ");
        var assignmentChoice = int.Parse(Console.ReadLine() ?? "");
        Console.WriteLine();
        // In a null coalescing expression of the form a ?? b, if a is non-null, the result is a; otherwise, the result is b. The operation evaluates b only if a is null.
        Console.ForegroundColor = ConsoleColor.Green;
        Exercises ex = new Exercises();
        switch (assignmentChoice)
        {
            case 1: ex.RunExerciseOne(); break;
            case 2: ex.RunExerciseTwo(); break;
            case 3: ex.RunExerciseThree(); break;
            case 4: ex.RunExerciseFour(); break;
            case 5: ex.RunExerciseFive(); break;
            case 6: ex.RunExerciseSix(); break;
            case 7: ex.RunExerciseSeven(); break;
            case 8: ex.RunExerciseEight(); break;
            case 9: ex.RunExerciseNine(); break;
            case 10: ex.RunExerciseTen(); break;
            case 11: ex.RunExerciseEleven(); break;
            case 12: ex.RunExerciseTwelve(); break;
            case 13: ex.RunExerciseThirteen(); break;
            case 14: ex.RunExerciseFourteen(); break;
            case 15: ex.RunExerciseFifteen(); break;
            case 16: ex.RunExerciseSixteen(); break;
            case 17: ex.RunExerciseSeventeen(); break;
            case 18: ex.RunExerciseEighteen(); break;
            case 19: ex.RunExerciseNineteen(); break;
            case 20: ex.RunExerciseTwenty(); break;
            case 21: ex.RunExerciseTwentyOne(); break;
            case 22: ex.RunExerciseTwentyTwo(); break;
            case 23: ex.RunExerciseTwentyThree(); break;
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

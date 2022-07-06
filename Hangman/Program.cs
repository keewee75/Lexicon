using System.Text;

Console.WriteLine("Welcome to Hangman The Game!\n");

Random rnd = new Random();
int guessCount = 0;
bool isCorrect = false;

string[] secretWordArray = new string[] { "array", "method", "value", "initiate", "string", "index" };
var secretRandomWord = rnd.Next(secretWordArray.Length);
string secretWord = secretWordArray[secretRandomWord];
char[] guess = new char[secretWord.Length];
StringBuilder incorrectLetters = new StringBuilder();

Console.WriteLine($"The secret word has {secretWord.Length} letters");
//Console.WriteLine(secretWord);

Console.Write("Guess a letter or the complete word: ");

for (int i = 0; i < secretWord.Length; i++)
{
    guess[i] = '_';
}

while (true && guessCount <= 9 && !isCorrect)
{
    string playerGuessString = Console.ReadLine();

    if (playerGuessString == secretWord)
    {
        isCorrect = true;

        Console.Write("Congrats! You guessed the correct word: ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(secretWord);
        Console.ResetColor();
        Console.ReadLine();
    }
    else if (playerGuessString.Length > 1)
    {
        Console.WriteLine("That is not the correct word.");
        DisplayCurrentStatus();
    }
    else if (playerGuessString.Length == 1 && !secretWord.Contains(playerGuessString))
    {
        if (incorrectLetters.ToString().Contains(playerGuessString))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"You have already guessed letter: {playerGuessString}");
            Console.ResetColor();
        }
        else
        {
            guessCount++;
            incorrectLetters.Append(playerGuessString);
        }
        DisplayCurrentStatus();
    }
    else if (playerGuessString.Length == 1 && secretWord.Contains(playerGuessString))
    {
        char playerGuessChar = Convert.ToChar(playerGuessString);

        if (guess.Contains(playerGuessChar))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"You have already guessed letter: {playerGuessString}");
            Console.ResetColor();
        }
        else
        {
            guessCount++;
            for (int j = 0; j < secretWord.Length; j++)
            {
                if (playerGuessChar == secretWord[j])
                {
                    guess[j] = playerGuessChar;
                }
            }
        }
        DisplayCurrentStatus();
    }
}


void DisplayCurrentStatus()
{
    Console.Write("Secret word: ");
    for (int i = 0; i < guess.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("{0} ", guess[i]);
    }
    Console.ResetColor();
    Console.WriteLine($"\nIncorrect letters: ({incorrectLetters}) , You have {10 - guessCount} tries left");
    Console.Write("\nGuess letter or word: ");
}
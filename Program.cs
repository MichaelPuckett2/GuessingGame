using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberGenerationManager = new NumberGenerationManager();
            Console.WriteLine("Guess a number between 0 and 100");
            var enteredValue = Console.ReadLine();

            while (int.TryParse(enteredValue, out int integer))
            { 
                var result = numberGenerationManager.GuessNumber(integer);

                switch (result)
                {
                    case NumberGuessResponse.TooHigh:
                        Console.WriteLine("Your guess is too high");
                        break;

                    case NumberGuessResponse.TooLow:
                        Console.WriteLine("Your guess is too low");
                        break;

                    case NumberGuessResponse.Correct:
                        Console.WriteLine($"Winner winner, chicken dinner. It took you {numberGenerationManager.GuessCounter} guesses.");
                        break;
                }

                if (result == NumberGuessResponse.Correct) break;

                enteredValue = Console.ReadLine();
            } 
        }
    }
}

using System;

namespace GuessingGame
{
    public class NumberGenerationManager
    {
        private readonly Random random;
        private int numberToGuess;
        public NumberGenerationManager()
        {
            random = new();
            numberToGuess = random.Next(0, 100);
            GuessCounter = 0;
        }

        public int GuessCounter { get; private set; }

        public NumberGuessResponse GuessNumber(int guess)
        {
            GuessCounter++;

            if (guess > numberToGuess)
            {
                return NumberGuessResponse.TooHigh;
            }
            else if (guess < numberToGuess)
            {
                return NumberGuessResponse.TooLow;
            }
            else
            {
                return NumberGuessResponse.Correct;
            }
        }
    }
}



using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Number Guessing Game!");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();

            int difficultyLevel = PromptDifficulty();
            int secretNumber = GenSecretNum();
            int maxGuesses = GetMaxGuesses(difficultyLevel);
            int currentGuess = 1;
        // loop for regular difficutlty levels
        while (currentGuess <= maxGuesses)
        {
            // handles the reamining number of guesses
            int remainingGuesses = maxGuesses - currentGuess + 1;

            // displays the current guess number and remaining guesses
            Console.WriteLine($"Guess #{currentGuess}: (Guesses Reamaining: {remainingGuesses})");
            // prompt for user guess
            Console.Write("your guess: ");
            int userGuess = int.Parse(Console.ReadLine());

            // check if the user guess matches secret number
            if (userGuess == secretNumber)
            {
                Console.WriteLine("CORRECT!");
                return;
            }
            else if (userGuess < secretNumber)
            {
                Console.WriteLine("TOO LOW!");
            }
            else
            {
                Console.WriteLine("TOO HIGH!");
            }
                // add to the guess counter
                currentGuess++;
        }

            // checks if user chooses cheater difficulty
           if (difficultyLevel == 4)
           {

            // loop for cheater difficulty with unlimited guesses
            while (true)
            {
                Console.WriteLine($"Guess #{currentGuess}:");
                Console.Write("Your guess: ");
                int userGuess = int.Parse(Console.ReadLine());

                if (userGuess == secretNumber)
                {
                    Console.WriteLine("CORRECT!");
                    return;
                }
                else
                {
                    Console.WriteLine("INCORRECT!");
                    currentGuess++;
                }
            }
           }
            // YOU LOSE 
           Console.WriteLine("OUT OF GUESSES YO");
           
        }

            //choose difficulty
        static int PromptDifficulty()
        {
            int difficultyLevel;

            do
            {
                 Console.WriteLine("Please select a difficulty level:");
            Console.WriteLine("1. Easy");
            Console.WriteLine("2. Medium");
            Console.WriteLine("3. Hard");
            Console.WriteLine("4. Cheater");
            Console.Write("Your choice: ");
            difficultyLevel = int.Parse(Console.ReadLine());
            } while (difficultyLevel < 1 || difficultyLevel > 4);

            return difficultyLevel;
        }


        // changes number of guesses allowed by difficulty chosen
        static int GetMaxGuesses(int difficultyLevel)
        {
            switch (difficultyLevel)
            {
                case 1:
                    return 8;
                case 2:
                    return 6;
                case 3:
                    return 4;
                case 4:
                    return int.MaxValue;
                default:
                    return 8;
            }
        }

            // gen random secret number
        static int GenSecretNum()
        {
            Random random = new Random();
            return random.Next(1, 101);
        }
    }



using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Number Guessing Game!");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();

            int secretNumber = GenSecretNum();
            int maxGuesses = 4;
            int currentGuess = 1;

        while (currentGuess <= maxGuesses)
        {
            int remainingGuesses = maxGuesses - currentGuess + 1;


            Console.WriteLine($"Guess #{currentGuess}: (Guesses Reamaining: {remainingGuesses})");
            Console.Write("your guess: ");
            int userGuess = int.Parse(Console.ReadLine());

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

                currentGuess++;
        }
            Console.WriteLine("OUT OF GUESSES");
           
        }
        static int GenSecretNum()
        {
            Random random = new Random();
            return random.Next(1, 101);
        }
    }

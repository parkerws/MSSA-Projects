using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bisection
{
    class NumberGuess
    {
        static Random rand = new Random();

        public static int HandleGuessInput()
        {
            int guess;
            while (!int.TryParse(Console.ReadLine(), out guess))
            {
                Console.WriteLine("Please enter a valid number");
            }

            return guess;

        }

        public static string HumanGuess(int guess)
        {
            int guesses = 1;
            int answer = rand.Next(1, 1000);

            while (guess != answer)
            {
                if (guess == answer)
                {
                    break;
                }
                else if (guess < answer)
                {

                    Console.WriteLine($"{guess} is too low");
                    guesses++;
                    guess = HandleGuessInput();
                }
                else
                {

                    Console.WriteLine($"{guess} is too high");
                    guesses++;
                    guess = HandleGuessInput();
                }

            }

            return $"\n\nCorrect! The answer is {answer}, found after {guesses} guesses.";
        }

    }
}

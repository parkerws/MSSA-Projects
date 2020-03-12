using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bisection
{
    class NumberGuess
    {
        static Random rand = new Random();
        public static double humanAverage = 0;
        public static int humanGameCounter = 0;

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
            int guesses = 0;
            int answer = rand.Next(1, 1000);

            while (guess != answer)
            {
                if (guess == answer)
                {
                    guesses++;
                    
                    
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
            humanAverage += guesses;
            ++humanGameCounter;
            return $"\n\nCorrect! The answer is {answer}, found after {guesses} guesses.\nThe average guesses across {humanGameCounter} games is {humanAverage / humanGameCounter}";
        }

    }
}

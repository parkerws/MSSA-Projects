using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Bisection
{
    public static class PresentationHandler
    {
        static int[] bisectionArr = Enumerable.Range(1, 10).ToArray();
        private static double humanAverage = 0;
        private static double computerAverage = 0;
        private static int humanGameCounter = 0;
        private static int computerGameCounter = 0;

        public static void Presenter()
        {
            Console.WriteLine(" ____________________________________\n" +
                              "|                                    |\n" +
                              "|       Please enter a choice:       |\n" +
                              "|   (1) Recursive Bisection Search   |\n" +
                              "|   (2) Iterative Bisection Search   |\n" +
                              "|   (3) Human Guessing Game          |\n" +
                              "|   (4) Computer Guessing Game       |\n" +
                              "|____________________________________|\n");

            string choice = Console.ReadLine();
            Console.Clear();
            try
            {
                if (choice.Trim() == "1")
                {

                    Console.WriteLine("Please enter a number, 1-10");
                    int input = NumberGuess.HandleGuessInput();
                    if (input < 0 || input > 10)
                    {
                        Console.WriteLine("Out of range. Please enter a number 1-10");
                        input = NumberGuess.HandleGuessInput();
                    }

                    Console.WriteLine(BinarySearch.RecursiveBisection(bisectionArr, input, 0, bisectionArr[^1]));

                }
                else if (choice.Trim() == "2")
                {
                    Console.WriteLine("Please enter a number, 1-10");
                    int input = NumberGuess.HandleGuessInput();
                    if (input < 0 || input > 10)
                    {
                        Console.WriteLine("Out of range. Please enter a number 1-10");
                        input = NumberGuess.HandleGuessInput();
                    }

                    Console.WriteLine(BinarySearch.IterativeBisection(bisectionArr, input));
                }
                else if (choice.Trim() == "3")
                {
                    Console.WriteLine("Guess a number 1-1000");
                    Console.WriteLine(NumberGuess.HumanGuess(NumberGuess.HandleGuessInput()));
                    
                }
                else if (choice.Trim() == "4")
                {
                    Console.WriteLine(MachineGuess.MachineGuessGame(MachineGuess.machineArr, 0,
                        MachineGuess.machineArr[^1]));

                }
                else
                {
                    Console.WriteLine("Please enter a valid selection");
                    Presenter();
                }

                Console.WriteLine("Would you like to return to the main menu? Y/n");
                string answer = Console.ReadLine();

                if (answer == "y" || answer == "Y")
                {
                    Console.Clear();
                    Presenter();
                }
                else
                {
                    Console.WriteLine("\n\nThanks for trying!");
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("No value entered. Enter a value:");
                choice = Console.ReadLine();

            }
        }
    }
}

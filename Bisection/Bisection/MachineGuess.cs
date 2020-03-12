using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;
using System.Linq;

namespace Bisection
{
    class MachineGuess
    {
        static Random rand = new Random();

        public static int[] machineArr = Enumerable.Range(0, 100).ToArray();
        public static int counter = 1;
        public static double computerAverage = 0;
        public static double computerGameCounter = 0;


        

    public static string MachineGuessGame(int[] arr, int start, int end)
    {
        
        int computerGuess = rand.Next(arr[start], arr[end]);
        int mid = (start + end) / 2;

        if (start > end)
        {
            return $"Number not found";
        }

        Console.WriteLine($"Is your guess {computerGuess}?\n\n (c)orrect, too (h)igh, or too (l)ow");
        string response = Console.ReadLine().ToLower();

        string reply = "";
        if (response == "c" || response == "correct")
        {
            computerGameCounter++;
            computerAverage += counter;
            reply =  $"Number found after {counter} guesses.\nThe average across {computerGameCounter} is {computerAverage / computerGameCounter}";
            counter = 1;
            
            return reply;
        }
        else if (response == "h" || response == "high")
        {
            counter++;
            return MachineGuessGame(arr, start, computerGuess - 1);
        }
        else if (response == "l" || response == "low")
        {
            counter++;
            return MachineGuessGame(arr, computerGuess + 1, end);
        }
        else
        {
            return $"Please enter a valid response";
        }


    }
    }
}

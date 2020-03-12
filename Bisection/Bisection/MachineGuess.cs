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
        private static int counter = 1;

        

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
        

        if (response == "c" || response == "correct")
        {
            return $"Number found after {counter} guesses";
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

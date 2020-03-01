using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculating_Averages
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer;
            Console.WriteLine("Which module would you like to access?" +
                "\n1. addNumbers()" +
                "\n2. averageNumbers()" +
                "\n3. specificAverages()" +
                "\n4. anyAverage()");
            
            while (int.TryParse(Console.ReadLine(), out answer) == false)
            {
                Console.WriteLine("Enter a valid number. What module would you like to access?" +
                "\n1.addNumbers()" +
                "\n2. averageNumbers()" +
                "\n3. specificAverages()" +
                "\n4. anyAverage()");
            }
            
            

                switch (answer)
                {
                    case 1:
                        addNumbers();
                        break;

                    case 2:
                        averageNumbers();
                        break;

                    case 3:
                        specificAverage();
                        break;

                    case 4:
                        anyAverage();
                        break;

                    default:
                        Console.WriteLine("Make a selection.");
                        break;
                }



            
           

        }

       static void addNumbers()
        {
            //Initialize array of size 10 to accept 10 numbers
            int[] numbers = new int[10];

            //Establish for loop that iterates 10 times to add numbers to array
            for (int i = 0; i < 10; i++)
            {
                //Prompt user for number i + 1 
                Console.Write($"Enter number {i + 1}: ");
                while (int.TryParse(Console.ReadLine(), out numbers[i]) == false)
                {
                    Console.WriteLine($"Please enter a valid number 1 - 100. Enter number {i + 1}: ");
                }
                //Take input from user and place it in index i of the array
                //numbers[i] = int.Parse(Console.ReadLine());


                //Control structure to ensure input is between 0 and 100
                if (numbers[i] >= 0 && numbers[i] <= 100)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Enter a number between 1 - 100");
                    i--;
                }
            }

            //Using the Sum() method for arrays, return the sum of all numbers in the array
           int answer = numbers.Sum();
            Console.WriteLine($"The sum is: {answer}.");
            
        }

        static void averageNumbers()
        {
            //Initialize array of size 10 to accept 10 numbers
            double[] numbers = new double[10];

            //Establish for loop that iterates 10 times to add numbers to array
            for (int i = 0; i < 10; i++)
            {
                
                //Prompt user for number i + 1 
                Console.Write($"Enter number {i + 1}: ");
                //Take input from user and place it in index i of the array - check to make sure it is a number 1-100
                while (double.TryParse(Console.ReadLine(), out numbers[i]) == false)
                {
                    Console.WriteLine($"Please enter a valid number 1 - 100. Enter number {i + 1}: ");
                }
                    

                //Control structure to ensure input is between 0 and 100
                if (numbers[i] >= 0 && numbers[i] <= 100)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Enter a number between 1 - 100");
                    i--;
                }
            }

            //Using the Sum() method for arrays, return the sum of all numbers in the array
            double answer = numbers.Average();
            Console.WriteLine($"The average is {answer}");
        }

        static void specificAverage()
        {
            int tests;
            double score = 0;
            double scoreTotal = 0;
            double average = 0;
            //Prompt user for the amount of test scores, place in variable. 
            Console.Write("How many test scores? ");
            //Check for valid input, if valid, put in variable tests
            while (int.TryParse(Console.ReadLine(), out tests) == false)
            {
                Console.WriteLine("Enter a valid number of tests");
            }
            
            //loop through and add scores for as many tests user input
            for (int i = 0; i < tests; i++)
            {
                //Enter test scores, check for valid input
                Console.Write($"Enter test score {i + 1}: ");
                while (double.TryParse(Console.ReadLine(), out score) == false)
                {
                    Console.WriteLine($"Enter a valid number 1 - 100 test {i + 1}: ");
                }
                
                //Ensure that counter is decremented if input is not valid
                if (score < 0 || score > 100)
                {
                    Console.WriteLine("Enter a score between 0 and 100.");
                    i--;
                }
                else
                {
                    scoreTotal += score;
                }
            }
            //return scoreTotal / tests;
            average = scoreTotal / tests;

            //control structure for grade scale
            if (average >= 90 && average <= 100)
            {
                Console.WriteLine($"Total: *{average}*. Grade: A");
            }
            else if (average >= 80 && average < 90)
            {
                Console.WriteLine($"Total: *{average}*. Grade: B");
            }
            else if (average >= 70 && average < 80)
            {
                Console.WriteLine($"Total: *{average}*. Grade: C");
            }
            else if (average >= 60 && average < 70)
            {
                Console.WriteLine($"Total: *{average}*. Grade: D");
            }
            else
            {
                Console.WriteLine($"Total: *{average}* Grade: F");
            }
        }

        static void anyAverage()
        {
            //Initialize variables
            int tests = 0;
            double numScore;
            double scoreTotal = 0;
            double average;
            string score = "1";
            
            
            //Accept input as string for user input
            Console.Write("Score Averager! type any non-number when finished entering scores. Enter a test score: ");
            score = Console.ReadLine();

            //Try to parse the string as a double. If it is succesful, place value in numScore.
            while (double.TryParse(score, out numScore))
            {
                //If the score is in the valid score range, add it to the total, increment the total amount of tests, and prompt for another score
                if (numScore >= 0 && numScore <= 100)
                {
                    Console.Write("Enter another score: ");
                    scoreTotal += numScore;
                    tests++;
                }
                //If the number is out of range, prompt user to enter another score
                else 
                {
                    Console.Write($"Sorry, {score} isn't a valid range. Enter a score 1-100: ");
                }
                //read another input from user
                score = Console.ReadLine();


            }

            //Calculate average by dividing the total points by the number of tests
            average = scoreTotal / tests;

            //Control structure for grade scale
            if (average >= 90 && average <= 100)
            {
                Console.WriteLine($"Total: *{average}*. Grade: A");
            }
            else if (average >= 80 && average < 90)
            {
                Console.WriteLine($"Total: *{average}*. Grade: B");
            }
            else if (average >= 70 && average < 80)
            {
                Console.WriteLine($"Total: *{average}*. Grade: C");
            }
            else if (average >= 60 && average < 70)
            {
                Console.WriteLine($"Total: *{average}*. Grade: D");
            }
            else
            {
                Console.WriteLine($"Total: *{average}* Grade: F");
            }


        }

           
        }


    }



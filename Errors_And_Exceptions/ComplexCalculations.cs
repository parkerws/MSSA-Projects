using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errors_And_Exceptions
{
    class ComplexCalculations
    {
        public static string CircleCalculations()
        {

            double radius;
            double circumference;
            double area;

            Console.WriteLine("\nPart 1, circumference and area of a circle.");

            //Try catch block to ensure the user enters a positive number. Not included in main loop so it can handle the particular issue early. 
            try
            {
                Console.Write("Enter an integer for the radius: ");
                radius = ParseStuff();

                if (radius <= 0)
                {
                    throw new Exception();
                }

                //Calculates the circumference and area of a circle based on user input, returns a string. 
                circumference = checked(2 * Math.PI * radius);
                area = checked(Math.PI * Math.Pow(radius, 2));
                return $"The circumference is: {circumference} and the area is: {area}.";
            }

            catch (Exception)
            {
                Console.WriteLine("You must enter a positive number. ");
                Console.ReadKey();
                return CircleCalculations();

            }

        }

        public static string HemisphereVolume()
        {
            double radius;
            double volume;
            // Part 2
            Console.WriteLine("\nPart 2, volume of a hemisphere.");
            //Try catch block to ensure the user enters a positive number. Not included in main loop so it can handle the particular issue early. 
            try
            {
                Console.Write("Enter a positive integer for the radius: ");
                radius = ParseStuff();

                if (radius <= 0)
                {
                    throw new Exception();
                }

                //Calculates the volume of a hemisphere and returns the value as a string
                volume = checked(((4 / 3) * Math.PI * Math.Pow(radius, 3) / 2));
                return $"The volume is {volume}";
            }
            
            catch (Exception)
            {
                Console.WriteLine("You must enter a positive number. ");
                Console.ReadKey();
                return HemisphereVolume();

            }

        }

        public static string TriangleArea()
        {
            Console.WriteLine("\nPart 3, area of a triangle (Heron's formula).");
            double sideA;
            double sideB;
            double sideC;
            double p;
            double area;
            
                
                Console.Write("Side A:  ");
                sideA = ParseStuff();

                Console.Write("Side B:  ");
                sideB = ParseStuff();

                Console.Write("Side C:  ");
                sideC = ParseStuff();
                
                //Calculates the area of a triangle usche
                p = checked((sideA + sideB + sideC) / 2);
                area = checked(Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC)));

                return $"The area is: {area}";

        }

        public static string QuadraticEquation()
        {
            double num1, num2, num3;
            double x, xFinal, denominator;
            double positive_num, negative_num;

            Console.WriteLine("\nPart 4, solving a quadratic equation.");

                Console.WriteLine("Enter three real numbers");
                Console.Write("First Number:  ");
                num1 = ParseStuff();

                Console.Write("Second Number:  ");
                num2 = ParseStuff();

                Console.Write("Third Number:  ");
                num3 = ParseStuff();

                x = checked(Math.Pow(num2, 2) - 4 * num1 * num3);

                //Takes the product of the quadratic equation prior to finding square root, to ensure that this number is not an imaginary number. 
                if (x < 0)
                    throw new ArgumentOutOfRangeException();

                xFinal = checked(Math.Sqrt(x));

                denominator = (2 * num1);

                negative_num = -1 * num2 - xFinal;
                positive_num = -1 * num2 + xFinal;

                return $"The positive solution is {positive_num / denominator}" +
                       $"\nThe negative solution is { negative_num / denominator }";


        }
        //This private method is used to help provide input validation for all numbers in program. Helps avoid complicated try/catch blocks for inappropriate user input. 
        private static double ParseStuff()
        {

            double number;

            while (double.TryParse(Console.ReadLine(), out number) == false)
            {
                Console.Write("Enter a valid number: ");
                
            }

            return number;
        }
    }
}


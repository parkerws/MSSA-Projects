using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1a
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1
            // Partially worked example
            Console.WriteLine("\nPart 1, circumference and area of a circle.");
            Console.Write("Enter an integer for the radius: ");

            string strradius = Console.ReadLine();
            double doubRadius = Double.Parse(strradius);
            double circumference = 2 * Math.PI * doubRadius;

            Console.WriteLine($"The circumference is {circumference}");

            // Implementation for area here
            double area = Math.PI * Math.Pow(doubRadius, 2);
            Console.WriteLine($"The area is {area}");

            // Part 2
            Console.WriteLine("\nPart 2, volume of a hemisphere.");

            // Implementation here
            Console.Write("Enter an integer for the radius: ");

            string strRadiusVolume = Console.ReadLine();
            double dRadiusVolume = Double.Parse(strRadiusVolume);
            double volume = ((4 / 3) * Math.PI * Math.Pow(dRadiusVolume, 3) / 2);
            Console.WriteLine($"The volume is {volume}");


            // Part 3
            Console.WriteLine("\nPart 3, area of a triangle (Heron's formula).");

            // Implementation here
            Console.WriteLine("Enter three values for the sides of a triangle");
            Console.Write("Side A:  ");
            int sideA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Side B:  ");
            int sideB = Convert.ToInt32(Console.ReadLine());

            Console.Write("Side C:  ");
            int sideC = Convert.ToInt32(Console.ReadLine());

            double p = (sideA + sideB + sideC) / 2;
            double areaTriangle = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));

            Console.WriteLine($"The area is {areaTriangle}");


            // Part 4
            Console.WriteLine("\nPart 4, solving a quadratic equation.");

            // Implementation here

            Console.WriteLine("Enter three real numbers");
            Console.Write("First Number:  ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Second Number:  ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Third Number:  ");
            int num3 = int.Parse(Console.ReadLine());

            double x = Math.Sqrt(Math.Pow(num2, 2) - 4 * num1 * num3);
            double denominator = (2 * num1);

            double negative_num = -1 * num2 - x;
            double positive_num = -1 * num2 + x;

            Console.WriteLine($"The positive solution is {positive_num / denominator}");
            Console.WriteLine($"The negative solution is {negative_num / denominator}");

            //Console.WriteLine(num1 * Math.Pow(x, 2) + num2 * x + num3);


        }
    }
}
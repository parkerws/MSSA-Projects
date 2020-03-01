using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlowExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeedCamera();
        }

        static string validNumber(int number)
        {
            
            
            if (number >= 1 && number <= 10)
                return "valid number";
            else
            {
                return "invalid number";
            }
        }

        static int compareNumbers()
        {
            int one;
            int two;
            Console.WriteLine("Enter two numbers: ");
            one = int.Parse(Console.ReadLine());
            two = int.Parse(Console.ReadLine());

            if (one > two)
            {
                return one;
            }
            else
            {
                return two;
            }
            

        }

        static string ImageOrientation()
        {
            int length;
            int height;
            Console.Write("Enter height of image: ");
            height = int.Parse(Console.ReadLine());
            Console.Write("Enter the length of the image: ");
            length = int.Parse(Console.ReadLine());

            if (height > length)
            {
                return "This image is portrait";
            }
            else if (length > height)
            {
                return "This image is landscape";
            }
            else
            {
                return "This picture is square";
            }
        }

        static void SpeedCamera()
        {
            int speed;
            int speedLimit;
            int points;

            Console.Write("Enter the speed limit: ");
            speedLimit = int.Parse(Console.ReadLine());

            Console.Write("Enter speed of car: ");
            speed = int.Parse(Console.ReadLine());

            if (speedLimit >= speed)
            {
                Console.WriteLine("OK");
            }
            else
            {
                points = (speed - speedLimit) / 5;
                Console.WriteLine($"Amount of points is: {points}");

                if (points > 12)
                {
                    Console.WriteLine("License Suspended");
                }
                else
                {
                    Console.WriteLine("Slow down");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Errors_And_Exceptions
{
    class Program
    {
        static void Main()
        {
            int selection;
            Console.WriteLine("Enter a selection: " +
                              "\n1. Circle Calculations" +
                              "\n2. Hemisphere Volume" +
                              "\n3. Area of a Triangle" +
                              "\n4. Quadratic Equation Calculator" +
                              "\n5. Exit.");

            while (int.TryParse(Console.ReadLine(), out selection) == false)
            {
                Console.Write("Not a number. ");
                Console.ReadLine();
            }

            while (selection < 1 || selection > 5)
            {
                Console.Write("Enter a number 1 - 5: ");
                int.TryParse(Console.ReadLine(), out selection);
            }

            try
            {

                switch (selection)
                {
                    case 1:
                        Console.WriteLine(ComplexCalculations.CircleCalculations());
                        break;

                    case 2:
                        Console.WriteLine(ComplexCalculations.HemisphereVolume());
                        break;

                    case 3:
                        Console.WriteLine(ComplexCalculations.TriangleArea());
                        break;

                    case 4:
                        Console.WriteLine(ComplexCalculations.QuadraticEquation());
                        break;

                    case 5:
                        Console.WriteLine("Exiting");
                        break;
                }

            }
            catch (OverflowException)
            {
                Console.WriteLine("The final product was too high of a number. ");
                Main();
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("Cant divide by 0. ");
                Main();
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Cant take square root of a negative number.");
                Main();
            }

            finally
            {
                Console.WriteLine("This program has finally terminated.");
            }
        }
    }
}

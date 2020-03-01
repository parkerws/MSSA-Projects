using System;
using MathAppLibrary;

namespace Math_Apps
{
    class Program
    {
        static void Main(string[] args)
        {
            int mathOperator;
            
            double x, y;
            Calculator calc = new Calculator();
            Console.WriteLine("What mathematical function would you like to perform?:" +
                "\n(1) Add" +
                "\n(2) Subtract" +
                "\n(3) Multiply" +
                "\n(4) Divide" +
                "\n(5) Exit ");
            while (!int.TryParse(Console.ReadLine(), out mathOperator))
            {
                Console.WriteLine("Enter a valid number");
            }

            while (mathOperator < 1 || mathOperator > 5)
            {
                    Console.WriteLine("Enter a valid selection 1 - 5:");
                    mathOperator = int.Parse(Console.ReadLine());
            }
            
            if (mathOperator == 5)
            {
                Console.WriteLine("Exiting.");
                return;
            }

            Console.WriteLine("Enter number 1: ");
            x = calc.PromptUser();

            Console.WriteLine("Enter number 2: ");
            y = calc.PromptUser();

            switch (mathOperator)
            {
                case 1:
                    Console.WriteLine($"{x} + {y} = {calc.Add(x, y)}");
                    break;

                case 2:
                    Console.WriteLine($"{x} - {y} = {calc.Subtract(x, y)}");
                    break;

                case 3:
                    Console.WriteLine($"{x} * {y} = {calc.Multiply(x, y)}");
                    break;

                case 4:
                    if (y == 0)
                    {
                        Console.WriteLine("Cannot divide by 0. Enter a new denominator: ");
                        y = calc.PromptUser();
                    }
                    Console.WriteLine($"{x} / {y} = {calc.Divide(x, y)}");
                    break;
                    

            
            }

            
            

        }
    }
}

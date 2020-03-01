using System;

namespace MathAppLibrary
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Add(double a, double b, double c)
        {
            return c + Add(a, b);
        }
        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            return a / b;
        }

        public double PromptUser()
        {
            double x;
            while (double.TryParse(Console.ReadLine(), out x) == false)
            {
                Console.WriteLine("Enter a valid number: ");
                
            }
            return x;
            
        }

    }
}

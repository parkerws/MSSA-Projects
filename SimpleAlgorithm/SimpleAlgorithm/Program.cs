using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1st Number");
            int one = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2nd Number");
            int two = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("3rd Number");
            int three = Convert.ToInt32(Console.ReadLine());



            int total = one + two + three;

            int result = total / 3;


            Console.WriteLine("total = " + total);
            Console.WriteLine("Result = " + result);

            if (total < 10)
            {
                Console.WriteLine("Fail!");
            }

            else if (total >= 10)
            {
                Console.WriteLine("Pass!");
            }
        }
    }
}
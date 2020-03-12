using System;
using System.Collections.Generic;
using System.Text;

namespace Bisection
{
    class BinarySearch
    {
        static int counter = 1;
        public static object RecursiveBisection(int[] arr, int value, int start, int end)
        {
            int half = (start + end) / 2;
            

            if (start > end)
            {
                return -1;
            }
            

            if (value == arr[half])
            {
                return $"{value} found after {counter} steps at index {half}";
            }

            else if (value < arr[half])
            {
                counter++;
                return $"{value} is lower than halfway point: {arr[half]}.\n" + RecursiveBisection(arr, value, start, half - 1);
            }
            else
            {
                counter++;
                return $"{value} is above {arr[half]}.\n" + RecursiveBisection(arr, value, half + 1, end);
            } }

        public static string IterativeBisection(int[] arr, int value)
        {
            int min = 0;
            int max = arr.Length - 1;
            

            while (min <= max)
            {
                int half = (min + max) / 2;
                if (value == arr[half])
                {
                    return $"{value} found after {counter} steps at index {half}";
                }
               
                else if (value < arr[half])
                {
                    counter++;
                    max = half - 1;
                }
                else
                {
                    counter++;
                    min = half + 1;
                }
                
            }
            return $"{value} not found";
            

        }
        }
    }

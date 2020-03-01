using System;

namespace ManipulatingArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int[][] arrayList = new int[3][]
            {
                new int[6] {0, 2, 4, 6, 8, 10},
                new int[5] {1, 3, 5, 7, 9},
                new int[12] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 }

            };

            int count = 0;
            Console.WriteLine("Array averages:\n");
            foreach (var array in arrayList)
            {
                Console.Write($"Array {(char)('A' + count)}: ");
                Console.WriteLine(ManipulatingArrays.ArrayAverage(array));
                count++;
            }

            Console.WriteLine("\n\nReversing arrays:\n");
            for (int i = 0; i < arrayList.Length; i++)
            {
                ManipulatingArrays.ReverseArray(arrayList[i]);
                Console.Write($"Array {(char)('A' + i)}: ");
                for (int j = 0; j < arrayList[i].Length; j++)
                {
                    Console.Write(arrayList[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\nResetting arrays:\n");
            for (int i = 0; i < arrayList.Length; i++)
            {
                ManipulatingArrays.ReverseArray(arrayList[i]);
                Console.Write($"Array {(char)('A' + i)}: ");
                for (int j = 0; j < arrayList[i].Length; j++)
                {
                    Console.Write(arrayList[i][j] + " ");
                }
                Console.WriteLine();
            }


            Console.Write("\n\nRotating Array A (2 left): ");
                foreach (var i in ManipulatingArrays.Rotate(arrayList[0], 2, "left"))
                {
                    Console.Write(i + " ");
                }

                Console.Write("\nRotating Array B (2 right): ");
                foreach (var j in ManipulatingArrays.Rotate(arrayList[1], 2, "right"))
                {
                    Console.Write(j + " ");
                }

                Console.Write("\nRotating Array C (4 left): ");
                foreach (var j in ManipulatingArrays.Rotate(arrayList[2], 4, "left"))
                {
                    Console.Write(j + " ");
                }




            count = 0;
            Console.WriteLine("\n\n\nArray sort, ascending:\n");
            foreach (int[] i in arrayList)
            {
                Console.Write($"Array {(char)('A' + count)}: ");
                ManipulatingArrays.BubbleSort(i);
                foreach (var j in i)
                {
                    Console.Write(j + " ");
                }
                count++;
                Console.WriteLine();
            }

        }       

    }
}

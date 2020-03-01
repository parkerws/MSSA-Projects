namespace ManipulatingArrays
{
    public class ManipulatingArrays
    {
        public static double ArrayAverage(int[] arr)
        {
            int count = arr.Length;
            double sum = 0;
            double average;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return average = sum / count;
        }

        public static int[] ReverseArray(int[] arr)
        {
            int[] temps = new int[arr.Length];
            temps = arr;

            for (int i = 0; i < arr.Length / 2; i++)
            {
                int temp = temps[i];
                temps[i] = temps[temps.Length - 1 - i];
                temps[temps.Length - 1 - i] = temp;
            }
            return temps;
        }

        public static int[] Rotate(int[] arr, int rotation, string direction)
        {
            int[] temps = new int[arr.Length];
            temps = arr;

            for (int i = 0; i < rotation; i++)
            {
                int holder;

                if (direction.ToLower() == "left")
                {
                    holder = temps[0];

                    for (int j = 0; j < temps.Length - 1; j++)
                    {
                        temps[j] = temps[j + 1];
                    }

                    temps[temps.Length - 1] = holder;
                }
                else if (direction.ToLower() == "right")
                {
                    holder = temps[temps.Length - 1];

                    for (int j = temps.Length - 1; j > 0; j--)

                    {
                        temps[j] = temps[j - 1];
                    }

                    temps[0] = holder;
                }
            }
            return temps;
        }

        public static int[] BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    int holder;
                    if (arr[j] > arr[j + 1])
                    {
                        holder = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = holder;
                    }
                }
            }

            return arr;
        }
    }
}
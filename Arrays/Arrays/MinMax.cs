using System;

namespace Arrays
{
    class MinMax
    {
        public MinMax()
        {
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter " + (i + 1) + " Element: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Original Array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            findMinMax(arr); // call method
        }

        void findMinMax(int[] arr)
        {
            int min = int.MaxValue;
            int max = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
                if (arr[i] > max)
                    max = arr[i];
            }

            Console.WriteLine("\nMin value from array: " + min);
            Console.WriteLine("Max value from array: " + max);
        }
    }
}

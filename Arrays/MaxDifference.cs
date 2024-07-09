using System;

namespace Arrays
{
    public class MaxDifference
    {
        public MaxDifference()
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

            int maxDifference = findMaxDifference(arr);
            Console.WriteLine("\nMaximum difference: " + maxDifference);
        }

        public int findMaxDifference(int[] arr)
        {
            int maxDifference = arr[1] - arr[0];
            int minElement = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] - minElement > maxDifference)
                {
                    maxDifference = arr[i] - minElement;
                }

                if (arr[i] < minElement)
                {
                    minElement = arr[i];
                }
            }

            return maxDifference;
        }
    }
}

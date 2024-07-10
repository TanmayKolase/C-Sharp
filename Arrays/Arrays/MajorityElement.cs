using System;

namespace Arrays
{
    class MajorityElement
    {
        public MajorityElement()
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

            FindMajorityElement(arr);
        }

        void FindMajorityElement(int[] arr)
        {
            int candidate = FindCandidate(arr);

            if (IsMajority(arr, candidate))
            {
                Console.WriteLine("\nMajority element: " + candidate);
            }
            else
            {
                Console.WriteLine("\nNo majority element found.");
            }
        }

        int FindCandidate(int[] arr)
        {
            int candidate = arr[0];
            int count = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == candidate)
                {
                    count++;
                }
                else
                {
                    count--;
                }

                if (count == 0)
                {
                    candidate = arr[i];
                    count = 1;
                }
            }

            return candidate;
        }

        bool IsMajority(int[] arr, int candidate)
        {
            int count = 0;
            foreach (int num in arr)
            {
                if (num == candidate)
                {
                    count++;
                }
            }

            return count > arr.Length / 2;
        }
    }
}

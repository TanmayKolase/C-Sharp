using System;

namespace Arrays
{
    public class RemoveElement
    {
        public RemoveElement()
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

            Console.Write("\nEnter the element to remove: ");
            int elementToRemove = int.Parse(Console.ReadLine());

            int indexToRemove = System.Array.IndexOf(arr, elementToRemove); // Use System.Array.IndexOf
            remove(arr, indexToRemove, elementToRemove);
        }

        void remove(int[] arr, int indexToRemove, int elementToRemove)
        {
            if (indexToRemove != -1)
            {
                int[] newArray = new int[arr.Length - 1];
                for (int i = 0, j = 0; i < arr.Length; i++)
                {
                    if (i == indexToRemove) continue;
                    newArray[j++] = arr[i];
                }

                Console.WriteLine("Array after removing element " + elementToRemove + ":");
                foreach (int num in newArray)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Element " + elementToRemove + " not found in the array.");
            }
        }
    }
}

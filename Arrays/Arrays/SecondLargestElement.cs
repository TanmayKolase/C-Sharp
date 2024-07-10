namespace Arrays
{
    class SecondLargestElement
    {
        public SecondLargestElement()
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

            findSecondLargestElement(arr);
        }

        void findSecondLargestElement(int[] arr)
        {
            if (arr.Length < 2)
            {
                Console.WriteLine("Array should have at least two elements");
                return;
            }

            int largest = int.MinValue;
            int secondLargest = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > largest)
                {
                    secondLargest = largest;
                    largest = arr[i];
                }
                else if (arr[i] > secondLargest && arr[i] < largest)
                {
                    secondLargest = arr[i];
                }
            }

            if (secondLargest == int.MinValue)
            {
                Console.WriteLine("\nNo second largest element found (array elements might be the same).");
            }
            else
            {
                Console.WriteLine("\nLargest: " + largest);
                Console.WriteLine("Second Largest: " + secondLargest);
            }
        }
    }
}

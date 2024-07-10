namespace SortingAlgorithms
{
    public class BubbleSort
    {
        public static void BubbleSortAlgorithm(int[] arr)
        {
            bool swapped = true;

            while (swapped)
            {
                swapped = false;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        swapped = true;
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                }
            }
        }

        public static void Main(string[] args)
        {
            int[] nums = { 5, 4, 3, 2, 1 };
            Console.Write("Before Sorting: ");
            Console.WriteLine(string.Join(", ", nums));

            // Call bubbleSort
            BubbleSortAlgorithm(nums);

            Console.Write("\nAfter Sorting: ");
            Console.WriteLine(string.Join(", ", nums));
        }
    }
}

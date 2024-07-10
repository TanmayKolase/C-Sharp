namespace SortingAlgorithms
{
    public class SelectionSort
    {
        public static void SelectionSortAlgorithm(int[] arr)
        {
            int length = arr.Length;

            for (int i = 0; i < length - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
        }

        public static void Main(string[] args)
        {
            int[] numbers = { 5, 4, 3, 2, 1 };
            Console.Write("Before Sorting: ");
            Console.WriteLine(string.Join(", ", numbers));

            // Call SelectionSort
            SelectionSortAlgorithm(numbers);

            Console.Write("\nAfter Sorting: ");
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}

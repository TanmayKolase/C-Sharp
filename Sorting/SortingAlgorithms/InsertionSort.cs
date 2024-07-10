namespace SortingAlgorithms
{
    public class InsertionSort
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 5, 4, 3, 2, 1 };

            Console.WriteLine("Before sorting: " + string.Join(", ", numbers));

            InsertionSortAlgorithm(numbers);

            Console.WriteLine("After sorting: " + string.Join(", ", numbers));
        }

        private static void InsertionSortAlgorithm(int[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                int currentValue = numbers[i];
                int j = i - 1;

                while (j >= 0 && currentValue < numbers[j])
                {
                    numbers[j + 1] = numbers[j];
                    j--;
                }
                numbers[j + 1] = currentValue;
            }
        }
    }
}

namespace SortingAlgorithms
{
    public class QuickSort
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 5, 4, 3, 2, 1 };

            Console.WriteLine("Before sorting: " + string.Join(", ", numbers));

            QuickSortAlgorithm(numbers, 0, numbers.Length - 1);

            Console.WriteLine("After sorting: " + string.Join(", ", numbers));
        }

        private static void QuickSortAlgorithm(int[] numbers, int lowIndex, int highIndex)
        {
            if (lowIndex >= highIndex)
            {
                return;
            }

            int pivot = numbers[highIndex];

            int leftPointer = lowIndex;
            int rightPointer = highIndex - 1;

            while (leftPointer <= rightPointer)
            {
                while (leftPointer <= rightPointer && numbers[leftPointer] <= pivot)
                {
                    leftPointer++;
                }

                while (leftPointer <= rightPointer && numbers[rightPointer] >= pivot)
                {
                    rightPointer--;
                }

                if (leftPointer < rightPointer)
                {
                    Swap(numbers, leftPointer, rightPointer);
                }
            }

            Swap(numbers, leftPointer, highIndex);

            QuickSortAlgorithm(numbers, lowIndex, leftPointer - 1);
            QuickSortAlgorithm(numbers, leftPointer + 1, highIndex);
        }

        private static void Swap(int[] numbers, int index1, int index2)
        {
            int temp = numbers[index1];
            numbers[index1] = numbers[index2];
            numbers[index2] = temp;
        }
    }
}

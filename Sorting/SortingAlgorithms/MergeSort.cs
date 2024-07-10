namespace SortingAlgorithms
{
    public class MergeSort
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 5, 4, 3, 2, 1 };

            Console.WriteLine("Before sorting: " + string.Join(", ", numbers));
            MergeSortAlgorithm(numbers);
            Console.WriteLine("After sorting: " + string.Join(", ", numbers));
        }

        private static void MergeSortAlgorithm(int[] numbers)
        {
            int length = numbers.Length;
            if (length <= 1) return;

            int middle = length / 2;
            int[] leftHalf = new int[middle];
            int[] rightHalf = new int[length - middle];

            Array.Copy(numbers, 0, leftHalf, 0, middle);
            Array.Copy(numbers, middle, rightHalf, 0, length - middle);

            MergeSortAlgorithm(leftHalf);
            MergeSortAlgorithm(rightHalf);

            // Call merge method to merge partitioned array
            Merge(numbers, leftHalf, rightHalf);
        }

        private static void Merge(int[] numbers, int[] leftHalf, int[] rightHalf)
        {
            int leftSize = leftHalf.Length;
            int rightSize = rightHalf.Length;

            int i = 0, j = 0, k = 0;
            while (i < leftSize && j < rightSize)
            {
                if (leftHalf[i] <= rightHalf[j])
                {
                    numbers[k] = leftHalf[i];
                    i++;
                }
                else
                {
                    numbers[k] = rightHalf[j];
                    j++;
                }
                k++;
            }

            while (i < leftSize)
            {
                numbers[k] = leftHalf[i];
                i++;
                k++;
            }
            while (j < rightSize)
            {
                numbers[k] = rightHalf[j];
                j++;
                k++;
            }
        }
    }
}

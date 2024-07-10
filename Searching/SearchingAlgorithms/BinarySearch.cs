namespace SearchingAlgorithms
{
    public class BinarySearch
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int size = arr.Length;

            // User enters the values
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter " + (i + 1) + " element: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter the element to search: ");
            int target = int.Parse(Console.ReadLine());

            int result = BinarySearchAlgorithm(arr, size, target);

            if (result != -1)
                Console.WriteLine("Element is present at index " + result);
            else
                Console.WriteLine("Element is not present in array");
        }

        public static int BinarySearchAlgorithm(int[] arr, int size, int target)
        {
            int left = 0;
            int right = size - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                    return mid;

                if (arr[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return -1;
        }
    }
}

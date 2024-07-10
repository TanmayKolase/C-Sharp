namespace SearchingAlgorithms
{
    public class LinearSearch
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

            int result = LinearSearchAlgorithm(arr, size, target);

            if (result != -1)
                Console.WriteLine("Element found at index: " + result);
            else
                Console.WriteLine("Element not found!");
        }

        public static int LinearSearchAlgorithm(int[] arr, int size, int target)
        {
            for (int i = 0; i < size; i++)
            {
                if (arr[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}

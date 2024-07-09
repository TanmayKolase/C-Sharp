namespace Arrays
{
    class CountOccurrences
    {
        public CountOccurrences()
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

            countOccurrences(arr);
        }

        static void countOccurrences(int[] array)
        {
            Console.WriteLine("\nElement\tCount");

            bool[] visited = new bool[array.Length];

            for (int i = 0; i < array.Length; i++)
            {

                if (visited[i])
                    continue;

                int count = 1;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] == array[i])
                    {
                        count++;
                        visited[j] = true; 
                    }
                }
                Console.WriteLine(array[i] + "\t" + count);
            }
        }
    }
}

namespace Arrays
{
    class CountOddEven
    {
        public CountOddEven()
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

            count(arr);
        }

        void count(int[] arr)
        {
            int odd = 0;
            int even = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    even++;
                else
                    odd++;
            }

            Console.WriteLine("\nOdd's count: "+odd);
            Console.WriteLine("Even's count: "+even);
        }
    }
}

namespace Arrays
{
    class SearchElement
    {
        public SearchElement()
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

            Console.Write("\nEnter key to found: ");
            int key = int.Parse(Console.ReadLine());

            int result = search(arr, key);
            if(result != -1 )
                Console.WriteLine("Element found at index "+result);
            else
                Console.WriteLine("Element not found");
        }

        int search(int[] arr,int key)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == key)
                    return i;
            }
            return -1;
        }
    }
}

namespace Arrays
{
    class RotateArray
    {
        public RotateArray()
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

            Console.Write("\nEnter rotation value(times): ");
            int k = int.Parse(Console.ReadLine());
            rotate(arr, k);

            Console.Write("Rotated Array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        void rotate(int[] arr,int k)
        {
            k = k % arr.Length;
            reverse(arr, 0, arr.Length - 1);
            reverse(arr, 0, k - 1);
            reverse(arr, k, arr.Length - 1);
        }

        void reverse(int[] arr , int start , int end)
        {
            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;

                start++;
                end--;
            }
        }
    }
}

namespace Array
{
    public class ReverseArray
    {
        //constructor
        public ReverseArray()
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

            reverse(arr);//call to reverse method

            Console.Write("\nReversed Array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        
        public void reverse(int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;

            while(start < end)
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

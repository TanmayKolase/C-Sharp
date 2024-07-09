using System;
using Arrays;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine(@"Choose a program to run:
1. Reverse Array
2. MinMax
3. Count Odd Even
4. Second Largest Element
5. Rotate Array
6. Search Element
7. Count Occurrences
8. Max Difference
9. Majority Element
10. Remove Element
Enter your choice (or enter -1 to exit): ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ReverseArray reverseArray = new ReverseArray();
                        break;
                    case 2:
                        MinMax minMax = new MinMax();
                        break;
                    case 3:
                        CountOddEven countOddEven = new CountOddEven();
                        break;
                    case 4:
                        SecondLargestElement secondLargestElement = new SecondLargestElement();
                        break;
                    case 5:
                        RotateArray rotateArray = new RotateArray();
                        break;
                    case 6:
                        SearchElement searchElement = new SearchElement();
                        break;
                    case 7:
                        CountOccurrences countOccurrences = new CountOccurrences();
                        break;
                    case 8:
                        MaxDifference maxDifference = new MaxDifference();
                        break;
                    case 9:
                        MajorityElement majorityElement = new MajorityElement();
                        break;
                    case 10:
                        RemoveElement removeElement = new RemoveElement();
                        break;
                    case -1:
                        Console.WriteLine("Exiting the program...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number from 1 to 10 or -1 to exit.");
                        break;
                }

                if (choice != -1)
                {
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (choice != -1);
        }
    }
}

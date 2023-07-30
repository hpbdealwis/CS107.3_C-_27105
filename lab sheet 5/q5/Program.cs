using System;

namespace ArrayOperationsNamespace
{
    public class ArrayOperations
    {
        public static int FindMinimum(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }
            return min;
        }

        public static int FindMaximum(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }

        public static double FindAverage(int[] arr)
        {
            double sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            return sum / arr.Length;
        }

        public static int[] ReverseArray(int[] arr)
        {
            int[] reversedArray = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                reversedArray[i] = arr[arr.Length - 1 - i];
            }
            return reversedArray;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter 10 integer values:");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Element {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int minimumValue = ArrayOperations.FindMinimum(arr);
            int maximumValue = ArrayOperations.FindMaximum(arr);
            double averageValue = ArrayOperations.FindAverage(arr);
            int[] reversedArray = ArrayOperations.ReverseArray(arr);

            Console.WriteLine($"Minimum value: {minimumValue}");
            Console.WriteLine($"Maximum value: {maximumValue}");
            Console.WriteLine($"Average value: {averageValue}");
            Console.WriteLine("Reversed order of values:");
            foreach (int num in reversedArray)
            {
                Console.Write($"{num} ");
            }

            // To keep the console window open until the user presses a key
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

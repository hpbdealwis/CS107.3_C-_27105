using System;

namespace ArrayOperationsNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the arrays: ");
            int size = int.Parse(Console.ReadLine());

            int[] array1 = new int[size];
            int[] array2 = new int[size];

            Console.WriteLine("\nEnter the elements of the first array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                array1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nEnter the elements of the second array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                array2[i] = int.Parse(Console.ReadLine());
            }

            int[] scalarSumArray = ScalarSum(array1, array2);
            int[] vectorSumArray = VectorSum(array1, array2);
            int[] vectorProductArray = VectorProduct(array1, array2);
            int scalarProductSum = ScalarProduct(array1, array2);

            Console.WriteLine("\nScalar Sum Array:");
            DisplayArray(scalarSumArray);

            Console.WriteLine("\nVector Sum Array:");
            DisplayArray(vectorSumArray);

            Console.WriteLine("\nVector Product Array:");
            DisplayArray(vectorProductArray);

            Console.WriteLine($"\nScalar Product Sum: {scalarProductSum}");

            // To keep the console window open until the user presses a key
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static int[] ScalarSum(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                result[i] = arr1[i] + arr2[i];
            }
            return result;
        }

        static int[] VectorSum(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                result[i] = arr1[i] + arr2[i];
            }
            return result;
        }

        static int[] VectorProduct(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                result[i] = arr1[i] * arr2[i];
            }
            return result;
        }

        static int ScalarProduct(int[] arr1, int[] arr2)
        {
            int sum = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                sum += arr1[i] * arr2[i];
            }
            return sum;
        }

        static void DisplayArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
        }
    }
}

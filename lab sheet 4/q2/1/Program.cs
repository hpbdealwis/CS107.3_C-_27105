using System;

namespace CircleProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius of the circle: ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double radius))
            {
                double area = CalculateCircleArea(radius);
                double circumference = CalculateCircleCircumference(radius);

                Console.WriteLine($"The area of the circle is: {area}");
                Console.WriteLine($"The circumference of the circle is: {circumference}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid numeric value for the radius.");
            }

            // To keep the console window open until the user presses a key
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static double CalculateCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        static double CalculateCircleCircumference(double radius)
        {
            return 2 * Math.PI * radius;
        }
    }
}

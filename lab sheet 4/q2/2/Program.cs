using System;

namespace CircleProperties
{
    public class FindValues
    {
        public double FindArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        public double FindCircumference(double radius)
        {
            return 2 * Math.PI * radius;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius of the circle: ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double radius))
            {
                FindValues finder = new FindValues();
                double area = finder.FindArea(radius);
                double circumference = finder.FindCircumference(radius);

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
    }
}

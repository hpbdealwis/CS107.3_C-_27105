using System;

namespace ArithmeticOperations
{
    public class CalculateValues
    {
        public double Addition(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Subtraction(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Multiplication(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Division(double num1, double num2)
        {
            if (num2 != 0)
                return num1 / num2;
            else
                throw new DivideByZeroException("Cannot divide by zero.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.Write("Enter your choice (1/2/3/4): ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.Write("Enter the first number: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double num2 = double.Parse(Console.ReadLine());

                CalculateValues calculator = new CalculateValues();
                double result = 0;

                switch (choice)
                {
                    case 1:
                        result = calculator.Addition(num1, num2);
                        Console.WriteLine($"The result of addition is: {result}");
                        break;
                    case 2:
                        result = calculator.Subtraction(num1, num2);
                        Console.WriteLine($"The result of subtraction is: {result}");
                        break;
                    case 3:
                        result = calculator.Multiplication(num1, num2);
                        Console.WriteLine($"The result of multiplication is: {result}");
                        break;
                    case 4:
                        try
                        {
                            result = calculator.Division(num1, num2);
                            Console.WriteLine($"The result of division is: {result}");
                        }
                        catch (DivideByZeroException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please choose a valid operation (1/2/3/4).");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please choose a valid operation (1/2/3/4).");
            }

            // To keep the console window open until the user presses a key
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

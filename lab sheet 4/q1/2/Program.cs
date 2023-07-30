using System;

namespace KilometerToMeterConverter
{
    public class ConvertValues
    {
        public void KilometerToMeter(double kilometer)
        {
            double meter = kilometer * 1000;
            Console.WriteLine($"{kilometer} kilometers is equal to {meter} meters.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the kilometer value: ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double kilometer))
            {
                ConvertValues converter = new ConvertValues();
                converter.KilometerToMeter(kilometer);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid numeric value for kilometers.");
            }

            // To keep the console window open until the user presses a key
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

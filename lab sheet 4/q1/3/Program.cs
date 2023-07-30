using System;

namespace KilometerToMeterConverter
{
    public class ConvertValues
    {
        public double KilometerToMeter(double kilometer)
        {
            double meter = kilometer * 1000;
            return meter;
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
                double meterValue = converter.KilometerToMeter(kilometer);
                Console.WriteLine($"{kilometer} kilometers is equal to {meterValue} meters.");
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

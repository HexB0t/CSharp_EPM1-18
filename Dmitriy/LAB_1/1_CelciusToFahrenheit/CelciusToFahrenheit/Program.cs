using System;

namespace CelciusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double tCelcius;
            double tFahrenheit;
            Console.Write("Enter Celsius:");
            tCelcius = Convert.ToDouble(Console.ReadLine());
            tFahrenheit = (tCelcius * 9 / 5)  + 32;
            Console.WriteLine("Celsius temperature {0}°C equal to {1}°F in Fahrenheit.", tCelcius, tFahrenheit);
            Console.ReadKey();
        }
    }
}


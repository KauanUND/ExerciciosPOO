using System;

namespace ConverterTemperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura em  Celsius:");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = ConverterCelsiusParaFahrenheit(celsius);

            Console.WriteLine($"A temperatura em  Fahrenheit é: {fahrenheit} °F");
        }

        static double ConverterCelsiusParaFahrenheit(double celsius)
        {
            double fahrenheit = (9 * celsius + 160) / 5;
            return fahrenheit;
        }
    }
}
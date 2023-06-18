using System;

namespace ConversaoTemperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura em  Fahrenheit:");
            double fahrenheit = double.Parse(Console.ReadLine());

            double celsius = ConverterFahrenheitParaCelsius(fahrenheit);

            Console.WriteLine($"A temperatura em Celsius é: {celsius} °C");
        }

        static double ConverterFahrenheitParaCelsius(double fahrenheit)
        {
            double celsius = (fahrenheit - 32) * 5 / 9;
            return celsius;
        }
    }
}
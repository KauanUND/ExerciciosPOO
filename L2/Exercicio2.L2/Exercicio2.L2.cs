using System;

namespace ConversaoDolarReal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a cotação do dólar:");
            double cotacaoDolar = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor em dólar:");
            double valorDolar = double.Parse(Console.ReadLine());

            double valorReal = ConverterDolarParaReal(valorDolar, cotacaoDolar);

            Console.WriteLine($"O valor em real é: R$ {valorReal}");
        }

        static double ConverterDolarParaReal(double valorDolar, double cotacaoDolar)
        {
            double valorReal = valorDolar * cotacaoDolar;
            return valorReal;
        }
    }
}
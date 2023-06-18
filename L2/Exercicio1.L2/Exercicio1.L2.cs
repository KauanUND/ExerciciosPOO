using System;

namespace CalculoEstoqueMedio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma quantidade mínima:");
            int quantidadeMinima = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite uma quantidade máxima:");
            int quantidadeMaxima = int.Parse(Console.ReadLine());

            double estoqueMedio = CalcularEstoqueMedio(quantidadeMinima, quantidadeMaxima);

            Console.WriteLine($"O estoque médio da peça é: {estoqueMedio}");
        }

        static double CalcularEstoqueMedio(int quantidadeMinima, int quantidadeMaxima)
        {
            double estoqueMedio = (quantidadeMinima + quantidadeMaxima) / 2.0;
            return estoqueMedio;
        }
    }
}
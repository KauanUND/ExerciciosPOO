using System;

namespace OrdemInversa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de números a serem lidos: ");
            int quantidade = int.Parse(Console.ReadLine());

            int[] numeros = new int[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nSequência inversa:");

            for (int i = quantidade - 1; i >= 0; i--)
            {
                Console.WriteLine(numeros[i]);
            }
        }
    }
}

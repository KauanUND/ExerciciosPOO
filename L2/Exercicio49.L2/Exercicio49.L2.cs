using System;

namespace VetoresIdenticos
{
    class Program
    {
        static void Main(string[] args)
        {
            const int N = 50;
            int[] V1 = new int[N];
            int[] V2 = new int[N];
            int contadorIdenticos = 0;

            Console.WriteLine("Digite os valores do vetor V1:");

            for (int i = 0; i < N; i++)
            {
                Console.Write($"V1[{i}]: ");
                V1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nDigite os valores do vetor V2:");

            for (int i = 0; i < N; i++)
            {
                Console.Write($"V2[{i}]: ");
                V2[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < N; i++)
            {
                if (V1[i] == V2[i])
                {
                    contadorIdenticos++;
                }
            }

            Console.WriteLine($"\nQuantidade de valores idênticos nas mesmas posições: {contadorIdenticos}");
        }
    }
}

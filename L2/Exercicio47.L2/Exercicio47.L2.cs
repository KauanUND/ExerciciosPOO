using System;

namespace ComparacaoNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];

            Console.WriteLine("Digite os 10 números do vetor:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\nDigite o número X: ");
            int x = int.Parse(Console.ReadLine());

            int maiores = 0;
            int menores = 0;
            int iguais = 0;

            for (int i = 0; i < 10; i++)
            {
                if (vetor[i] > x)
                {
                    maiores++;
                }
                else if (vetor[i] < x)
                {
                    menores++;
                }
                else
                {
                    iguais++;
                }
            }

            Console.WriteLine($"\nQuantidade de números maiores que X: {maiores}");
            Console.WriteLine($"Quantidade de números menores que X: {menores}");
            Console.WriteLine($"Quantidade de números iguais a X: {iguais}");
        }
    }
}

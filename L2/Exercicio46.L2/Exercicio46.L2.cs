using System;

namespace ProdutoEscalar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de elementos dos vetores: ");
            int quantidade = int.Parse(Console.ReadLine());

            int[] vetorX = new int[quantidade];
            int[] vetorY = new int[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write($"Digite o {i + 1}º elemento do vetor X: ");
                vetorX[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write($"Digite o {i + 1}º elemento do vetor Y: ");
                vetorY[i] = int.Parse(Console.ReadLine());
            }

            int produtoEscalar = 0;

            for (int i = 0; i < quantidade; i++)
            {
                produtoEscalar += vetorX[i] * vetorY[i];
            }

            Console.WriteLine($"\nProduto escalar: {produtoEscalar}");
        }
    }
}

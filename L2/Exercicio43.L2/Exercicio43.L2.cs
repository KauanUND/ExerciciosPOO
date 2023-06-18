using System;

namespace CalculoGraosXadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalGraos = 0;
            int graosQuadro = 1;

            for (int quadro = 1; quadro <= 64; quadro++)
            {
                totalGraos += graosQuadro;
                graosQuadro *= 2;
            }

            Console.WriteLine($"O monge esperava receber  {totalGraos} grãos de trigo.");
        }
    }
}
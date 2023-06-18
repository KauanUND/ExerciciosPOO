using System;

namespace CalculoTemposCorrida
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de voltas: ");
            int quantidadeVoltas = int.Parse(Console.ReadLine());

            double[] temposVoltas = new double[quantidadeVoltas];

            Console.WriteLine("Digite os tempos das voltas:");

            for (int i = 0; i < quantidadeVoltas; i++)
            {
                Console.Write($"Volta {i + 1}: ");
                temposVoltas[i] = double.Parse(Console.ReadLine());
            }

            double melhorTempo = temposVoltas[0];
            int voltaMelhorTempo = 1;
            double somaTempos = temposVoltas[0];

            for (int i = 1; i < quantidadeVoltas; i++)
            {
                if (temposVoltas[i] < melhorTempo)
                {
                    melhorTempo = temposVoltas[i];
                    voltaMelhorTempo = i + 1;
                }

                somaTempos += temposVoltas[i];
            }

            double tempoMedio = somaTempos / quantidadeVoltas;

            Console.WriteLine($"Melhor tempo: {melhorTempo}");
            Console.WriteLine($"Volta do melhor tempo: {voltaMelhorTempo}");
            Console.WriteLine($"Tempo médio: {tempoMedio}");
        }
    }
}

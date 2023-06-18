using System;

namespace ContagemNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            const int tamanhoMaximo = 100;
            int[] vetor = new int[tamanhoMaximo];
            int contador1 = 0;
            int contador3 = 0;
            int contador4 = 0;

            Console.WriteLine("Digite os números inteiros e positivos (digite -1 para sair):");

            // Leitura do vetor
            int posicao = 0;
            while (posicao < tamanhoMaximo)
            {
                int numero = int.Parse(Console.ReadLine());

                if (numero == -1)
                {
                    break;
                }

                vetor[posicao] = numero;
                posicao++;
            }

            // Contagem dos números 1, 3 e 4
            for (int i = 0; i < posicao; i++)
            {
                if (vetor[i] == 1)
                {
                    contador1++;
                }
                else if (vetor[i] == 3)
                {
                    contador3++;
                }
                else if (vetor[i] == 4)
                {
                    contador4++;
                }
            }

            Console.WriteLine($"Número de vezes que aparece o 1: {contador1}");
            Console.WriteLine($"Número de vezes que aparece o 3: {contador3}");
            Console.WriteLine($"Número de vezes que aparece o 4: {contador4}");
        }
    }
}

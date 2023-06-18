using System;

namespace AgenciaModelos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[20];
            int[] idades = new int[20];
            string[] candidatasAptas = new string[20];
            int contadorAptas = 0;

            Console.WriteLine("Digite os nomes das candidatas e suas idades:");

            for (int i = 0; i < 20; i++)
            {
                Console.Write($"Nome da candidata {i + 1}: ");
                nomes[i] = Console.ReadLine();

                Console.Write($"Idade da candidata {i + 1}: ");
                idades[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 20; i++)
            {
                if (idades[i] >= 18 && idades[i] <= 20)
                {
                    candidatasAptas[contadorAptas] = nomes[i];
                    contadorAptas++;
                }
            }

            Console.WriteLine("\nCandidatas aptas para a campanha publicitária:");

            for (int i = 0; i < contadorAptas; i++)
            {
                Console.WriteLine(candidatasAptas[i]);
            }
        }
    }
}

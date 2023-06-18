using System;

namespace AnaliseNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidadeNumeros = 10;
            int[] numeros = new int[quantidadeNumeros];

            for (int i = 0; i < quantidadeNumeros; i++)
            {
                Console.WriteLine($"Digite o {i + 1}º número:");
                numeros[i] = int.Parse(Console.ReadLine());

                if (numeros[i] <= 0)
                {
                    Console.WriteLine("O número deve ser inteiro e positivo. Digite novamente:");
                    i--;
                }
            }

            int maiorValor = EncontrarMaiorValor(numeros);
            int menorValor = EncontrarMenorValor(numeros);
            double media = CalcularMedia(numeros);

            Console.WriteLine($"O maior valor é: {maiorValor}");
            Console.WriteLine($"O menor valor é: {menorValor}");
            Console.WriteLine($"A média dos números é: {media}");
        }

        static int EncontrarMaiorValor(int[] numeros)
        {
            int maior = int.MinValue;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > maior)
                {
                    maior = numeros[i];
                }
            }

            return maior;
        }

        static int EncontrarMenorValor(int[] numeros)
        {
            int menor = int.MaxValue;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                }
            }

            return menor;
        }

        static double CalcularMedia(int[] numeros)
        {
            int soma = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];
            }

            double media = (double)soma / numeros.Length;
            return media;
        }
    }
}
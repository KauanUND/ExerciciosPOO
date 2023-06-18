using System;

class Program
{
    static void Main(string[] args)
    {
        int a, b, c;

        Console.WriteLine("Digite o valor de a:");
        a = LerNumeroMaiorQueZero();

        Console.WriteLine("Digite o valor de b:");
        b = LerNumeroMaiorQueZero();

        Console.WriteLine("Digite o valor de c:");
        c = LerNumeroMaiorQueZero();

        int menor = Math.Min(Math.Min(a, b), c);
        int maior = Math.Max(Math.Max(a, b), c);

        int resultadoMultiplicacao = menor * maior;
        int resultadoDivisao = maior / menor;

        Console.WriteLine("Menor valor multiplicado pelo maior: " + resultadoMultiplicacao);
        Console.WriteLine("Maior valor dividido pelo menor: " + resultadoDivisao);
    }

    static int LerNumeroMaiorQueZero()
    {
        int numero;

        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out numero) && numero > 0)
            {
                return numero;
            }

            Console.WriteLine("Valor inválido! Digite novamente um número maior que zero:");
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite a quantidade de números a serem processados: ");
        int quantidade = int.Parse(Console.ReadLine());

        for (int i = 0; i < quantidade; i++)
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            long fatorial = CalcularFatorial(numero);
            Console.WriteLine($"O fatorial de {numero} é {fatorial}");
        }
    }

    static long CalcularFatorial(int numero)
    {
        long fatorial = 1;

        for (int i = 1; i <= numero; i++)
        {
            fatorial *= i;
        }

        return fatorial;
    }
}
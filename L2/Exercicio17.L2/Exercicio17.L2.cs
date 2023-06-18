using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite um número inteiro entre 0 e 9:");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero >= 0 && numero <= 9)
        {
            Console.WriteLine("Valor válido.");
        }
        else
        {
            Console.WriteLine("Valor inválido.");
        }
    }
}
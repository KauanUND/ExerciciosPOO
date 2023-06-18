using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o número:");
        int numero = int.Parse(Console.ReadLine());

        int a = 0;
        int b = 0;

        if (numero > 0)
        {
            a = numero;
        }
        else if (numero < 0)
        {
            b = numero;
        }

        Console.WriteLine("Valor armazenado em A: " + a);
        Console.WriteLine("Valor armazenado em B: " + b);
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número (inteiro por favor meu amor):");
        int numero = int.Parse(Console.ReadLine());

        int resultado;

        if (numero % 2 == 0)
        {
            resultado = numero + 5;
        }
        else
        {
            resultado = numero + 8;
        }

        Console.WriteLine("O resultado é: " + resultado);
    }
}
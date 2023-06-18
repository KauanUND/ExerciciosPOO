using System;

class Program
{
    static void Main(string[] args)
    {
        int menor = int.MaxValue;
        int maior = int.MinValue;

        Console.WriteLine("Informe os números:");
        Console.WriteLine("Digite um número negativo para encerrar o programa.");

        while (true)
        {
            Console.Write("Número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero < 0)
                break;

            if (numero < menor)
                menor = numero;

            if (numero > maior)
                maior = numero;
        }

        if (menor != int.MaxValue)
        {
            Console.WriteLine("O menor número é: " + menor);
            Console.WriteLine("O maior número é: " + maior);
        }
        else
        {
            Console.WriteLine("Nenhum número foi informado.");
        }
    }
}
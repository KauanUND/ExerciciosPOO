using System;

class Program
{
    static void Main(string[] args)
    {
        int numero;
        int somaPares = 0;
        int somaImpares = 0;

        Console.WriteLine("Digite uma sequência de números positivos, utilize um numero negativo para encerrar:");

        do
        {
            numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine(numero + " é um número par.");
                    somaPares += numero;
                }
                else
                {
                    Console.WriteLine(numero + " é um número ímpar.");
                    somaImpares += numero;
                }
            }
        } while (numero > 0);

        Console.WriteLine("Soma dos números pares: " + somaPares);
        Console.WriteLine("Soma dos números ímpares: " + somaImpares);
    }
}
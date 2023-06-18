using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Digite um número inteiro (0 para sair):");
            int numero = int.Parse(Console.ReadLine());

            if (numero == 0)
            {
                break;
            }
            else if (numero > 0)
            {
                Console.WriteLine("O número é positivo.");
            }
            else
            {
                Console.WriteLine("O número é negativo.");
            }
        }

        Console.WriteLine("Programa encerrado.");
    }
}
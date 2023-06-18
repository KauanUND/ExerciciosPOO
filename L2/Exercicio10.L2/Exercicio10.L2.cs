using System;

namespace DoisNumerosRelacionamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número inteiro:");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número inteiro:");
            int numero2 = int.Parse(Console.ReadLine());

            if (numero1 == numero2)
            {
                Console.WriteLine("Os números são iguais.");
            }
            else
            {
                Console.WriteLine("Os números são diferentes.");

                if (numero1 > numero2)
                {
                    Console.WriteLine("O primeiro número é maior que o segundo.");
                }
                else
                {
                    Console.WriteLine("O primeiro número é menor que o segundo.");
                }

                if (numero1 >= numero2)
                {
                    Console.WriteLine("O primeiro número é maior ou igual ao segundo.");
                }
                else
                {
                    Console.WriteLine("O primeiro número é menor ou igual ao segundo.");
                }
            }
        }
    }
}
using System;

namespace MaiorMenorNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior = int.MinValue;
            int menor = int.MaxValue;

            Console.WriteLine("Digite uma sequência de números (digite 0 para parar):");

            bool parar = false;

            while (!parar)
            {
                int numero = int.Parse(Console.ReadLine());

                if (numero == 0)
                {
                    parar = true;
                }
                else
                {
                    if (numero > maior)
                    {
                        maior = numero;
                    }

                    if (numero < menor)
                    {
                        menor = numero;
                    }
                }
            }

            Console.WriteLine($"Maior número: {maior}");
            Console.WriteLine($"Menor número: {menor}");
        }
    }
}

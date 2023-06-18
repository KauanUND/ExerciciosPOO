using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número maior que 0 e menor que 10: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero > 0 && numero < 10)
        {
            int contador = 0;
            int somaQuadrados = 0;
            int numeroImpar = numero % 2 == 0 ? numero + 1 : numero;

            while (contador < 20)
            {
                somaQuadrados += numeroImpar * numeroImpar;
                numeroImpar += 2;
                contador++;
            }

            Console.WriteLine("A soma dos quadrados dos 20 primeiros números ímpares a partir de " + numero + " é: " + somaQuadrados);
        }
        else
        {
            Console.WriteLine("O número informado não está dentro do intervalo válido.");
        }
    }
}
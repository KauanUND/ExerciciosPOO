using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero > 0)
        {
            int dobro = numero * 2;
            Console.WriteLine("O dobro do número é: " + dobro);
        }
        else if (numero < 0)
        {
            int triplo = numero * 3;
            Console.WriteLine("O triplo do número é: " + triplo);
        }
        else
        {
            Console.WriteLine("O número é zero");
        }
    }
}
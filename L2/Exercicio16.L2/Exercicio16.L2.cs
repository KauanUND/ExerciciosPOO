using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro número:");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        if (numero1 > numero2)
        {
            Console.WriteLine("O Maior número e: " + numero1);
            Console.WriteLine("O Menor número e : " + numero2);
        }
        else if (numero2 > numero1)
        {
            Console.WriteLine("O Maior número e: " + numero2);
            Console.WriteLine("O Menor número e: " + numero1);
        }
        else
        {
            Console.WriteLine("Os dois números são iguais.");
        }
    }
}
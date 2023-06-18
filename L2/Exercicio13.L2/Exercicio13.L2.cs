using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro número:");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o terceiro número:");
        int numero3 = Convert.ToInt32(Console.ReadLine());

        int[] numeros = { numero1, numero2, numero3 };
        Array.Sort(numeros);
        Array.Reverse(numeros);

        Console.WriteLine("Valores em ordem decrescente:");
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }
}
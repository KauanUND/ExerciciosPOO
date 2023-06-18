using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o valor de A:");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o valor de B:");
        int b = Convert.ToInt32(Console.ReadLine());

        TrocarValores(ref a, ref b);

        Console.WriteLine(" Os Valores trocados são:");
        Console.WriteLine("A: " + a);
        Console.WriteLine("B: " + b);
    }

    public static void TrocarValores(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
}
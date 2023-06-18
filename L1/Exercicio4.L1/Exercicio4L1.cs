using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o valor de A:");
        int A = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor de B:");
        int B = int.Parse(Console.ReadLine());

        int C;

        if (A == B)
        {
            C = A + B;
        }
        else
        {
            C = A * B;
        }

        Console.WriteLine("O resultado é: " + C);
    }
}
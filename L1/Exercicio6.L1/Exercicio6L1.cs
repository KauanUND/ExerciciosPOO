using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro valor (true/false):");
        bool valor1 = bool.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor (true/false):");
        bool valor2 = bool.Parse(Console.ReadLine());

        if (valor1 && valor2)
        {
            Console.WriteLine("Os valores são True.");
        }
        else
        {
            Console.WriteLine("Pelo menos um dos valores é false.");
        }
    }
}
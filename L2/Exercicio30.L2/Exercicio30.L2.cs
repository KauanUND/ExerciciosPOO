using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite a o numero da tabuada: ");
        int numero = int.Parse(Console.ReadLine());

        Console.WriteLine("Tabuada do número " + numero + ":");

        for (int i = 1; i <= 10; i++)
        {
            int resultado = numero * i;
            Console.WriteLine(numero + " x " + i + " = " + resultado);
        }
    }
}
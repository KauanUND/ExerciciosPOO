using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite um número inteiro por favor:");
        int numero = Convert.ToInt32(Console.ReadLine());

        int modulo = Calcular(numero);

        Console.WriteLine("Módulo do número: " + modulo);
    }

    public static int Calcular(int numero)
    {
        if (numero >= 0)
        {
            return numero;
        }
        else
        {
            return numero * (-1);
        }
    }
}
using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite um número inteiro um numero entre 1 e 3:");
        int codigo = Convert.ToInt32(Console.ReadLine());

        switch (codigo)
        {
            case 1:
                Console.WriteLine("Um");
                break;
            case 2:
                Console.WriteLine("Dois");
                break;
            case 3:
                Console.WriteLine("Três");
                break;
            default:
                Console.WriteLine("Código inválido");
                break;
        }
    }
}
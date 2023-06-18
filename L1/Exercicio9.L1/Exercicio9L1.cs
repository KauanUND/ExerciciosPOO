using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a altura em metros:");
        double altura = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o sexo em M ou F:");
        char sexo = char.Parse(Console.ReadLine());

        double pesoIdeal;

        if (sexo == 'M' || sexo == 'm')
        {
            pesoIdeal = (72.7 * altura) - 58;
        }
        else if (sexo == 'F' || sexo == 'f')
        {
            pesoIdeal = (62.1 * altura) - 44.7;
        }
        else
        {
            Console.WriteLine("Letra Invalida");
            return;
        }

        Console.WriteLine("O peso ideal é: " + pesoIdeal.ToString("F2") + " kg");
    }
}
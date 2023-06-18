using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro valor inteiro:");
        int valor1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor inteiro:");
        int valor2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o terceiro valor inteiro:");
        int valor3 = int.Parse(Console.ReadLine());

        int maior, meio, menor;

        if (valor1 > valor2 && valor1 > valor3)
        {
            maior = valor1;
            if (valor2 > valor3)
            {
                meio = valor2;
                menor = valor3;
            }
            else
            {
                meio = valor3;
                menor = valor2;
            }
        }
        else if (valor2 > valor1 && valor2 > valor3)
        {
            maior = valor2;
            if (valor1 > valor3)
            {
                meio = valor1;
                menor = valor3;
            }
            else
            {
                meio = valor3;
                menor = valor1;
            }
        }
        else
        {
            maior = valor3;
            if (valor1 > valor2)
            {
                meio = valor1;
                menor = valor2;
            }
            else
            {
                meio = valor2;
                menor = valor1;
            }
        }

        Console.WriteLine("Valores em ordem decrescente: " + maior + ", " + meio + ", " + menor);
    }
}
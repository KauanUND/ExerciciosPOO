using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Selecione uma das opções:");
        Console.WriteLine("1 - Adição");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");

        int opcao = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o primeiro número:");
        double numero1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        double numero2 = double.Parse(Console.ReadLine());

        double resultado = 0;

        switch (opcao)
        {
            case 1:
                resultado = numero1 + numero2;
                Console.WriteLine("Resultado da adição: " + resultado);
                break;
            case 2:
                resultado = numero1 - numero2;
                Console.WriteLine("Resultado da subtração: " + resultado);
                break;
            case 3:
                resultado = numero1 * numero2;
                Console.WriteLine("Resultado da multiplicação: " + resultado);
                break;
            case 4:
                if (numero2 != 0)
                {
                    resultado = numero1 / numero2;
                    Console.WriteLine("Resultado da divisão: " + resultado);
                }
                else
                {
                    Console.WriteLine("Não e possivel a divisão por zero.");
                }
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
}
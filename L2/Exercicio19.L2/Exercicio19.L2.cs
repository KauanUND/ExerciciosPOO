using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o valor do lado A:");
        double ladoA = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o valor do lado B:");
        double ladoB = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o valor do lado C:");
        double ladoC = Convert.ToDouble(Console.ReadLine());

        if (ladoA < ladoB + ladoC && ladoB < ladoA + ladoC && ladoC < ladoA + ladoB)
        {
            if (ladoA == ladoB && ladoB == ladoC)
            {
                Console.WriteLine("Triângulo equilátero");
            }
            else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
            {
                Console.WriteLine("Triângulo isósceles");
            }
            else
            {
                Console.WriteLine("Triângulo escaleno");
            }
        }
        else
        {
            Console.WriteLine("Não é um triângulo válido");
        }
    }
}
using System;

namespace OperacoesPropriedadeDistributiva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de A:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de C:");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de D:");
            int d = int.Parse(Console.ReadLine());

            int resultado;

            resultado = a + b;
            Console.WriteLine($"{a} + {b} = {resultado}");

            resultado = a + c;
            Console.WriteLine($"{a} + {c} = {resultado}");

            resultado = a + d;
            Console.WriteLine($"{a} + {d} = {resultado}");

            resultado = b + c;
            Console.WriteLine($"{b} + {c} = {resultado}");

            resultado = b + d;
            Console.WriteLine($"{b} + {d} = {resultado}");

            resultado = c + d;
            Console.WriteLine($"{c} + {d} = {resultado}");

            resultado = a * b;
            Console.WriteLine($"{a} * {b} = {resultado}");

            resultado = a * c;
            Console.WriteLine($"{a} * {c} = {resultado}");

            resultado = a * d;
            Console.WriteLine($"{a} * {d} = {resultado}");

            resultado = b * c;
            Console.WriteLine($"{b} * {c} = {resultado}");

            resultado = b * d;
            Console.WriteLine($"{b} * {d} = {resultado}");

            resultado = c * d;
            Console.WriteLine($"{c} * {d} = {resultado}");
        }
    }
}
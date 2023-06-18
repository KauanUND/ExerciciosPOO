using System;

namespace CalculoVolumeLataOleo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o raio da lata de óleo:");
            double raio = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura da lata de óleo:");
            double altura = double.Parse(Console.ReadLine());

            double volume = CalcularVolumeLataOleo(raio, altura);

            Console.WriteLine($"O volume da lata de óleo é: {volume} em unidades cúbicas");
        }

        static double CalcularVolumeLataOleo(double raio, double altura)
        {
            double volume = 3.14159 * raio * raio * altura;
            return volume;
        }
    }
}
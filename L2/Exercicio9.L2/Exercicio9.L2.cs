using System;

namespace CalculoIdadeEmDias
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a sua idade em anos:");
            int anos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a sua idade em meses:");
            int meses = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a sua idade em dias:");
            int dias = int.Parse(Console.ReadLine());

            int idadeEmDias = CalcularIdadeEmDias(anos, meses, dias);

            Console.WriteLine($"A idade em dias é: {idadeEmDias} dias");
        }

        static int CalcularIdadeEmDias(int anos, int meses, int dias)
        {
            int idadeEmDias = (anos * 365) + (meses * 30) + dias;
            return idadeEmDias;
        }
    }
}
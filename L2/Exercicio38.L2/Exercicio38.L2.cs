using System;

namespace CalculoSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            bool encerrarPrograma = false;

            while (!encerrarPrograma)
            {
                Console.WriteLine("Informe o código do operário:");
                int codigo = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe o número de horas trabalhadas:");
                int horasTrabalhadas = int.Parse(Console.ReadLine());

                double salarioPorHora = 10.0;
                double salarioExcedente = 0.0;

                if (horasTrabalhadas > 50)
                {
                    int horasExcedentes = horasTrabalhadas - 50;
                    salarioExcedente = horasExcedentes * 20.0;
                    horasTrabalhadas -= horasExcedentes;
                }

                double salarioTotal = horasTrabalhadas * salarioPorHora;

                Console.WriteLine($"Salário total: R$ {salarioTotal:F2}");
                Console.WriteLine($"Salário excedente: R$ {salarioExcedente:F2}");

                Console.WriteLine("Deseja encerrar o programa? Digite S ou N");
                string resposta = Console.ReadLine();

                encerrarPrograma = (resposta.ToLower() == "s");

                Console.Clear();
            }
        }
    }
}

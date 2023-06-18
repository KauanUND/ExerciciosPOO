using System;

namespace ControlePoluicao
{
    class Program
    {
        static void Main(string[] args)
        {
            bool encerrarPrograma = false;

            while (!encerrarPrograma)
            {
                Console.WriteLine("Informe o índice de poluição medido:");
                double indicePoluicao = double.Parse(Console.ReadLine());

                if (indicePoluicao >= 0.5)
                {
                    Console.WriteLine("Notificação para todos os grupos: Paralisar atividades!");
                }
                else if (indicePoluicao >= 0.4)
                {
                    Console.WriteLine("Notificação para o 1º e 2º grupo: Suspender atividades!");
                }
                else if (indicePoluicao >= 0.3)
                {
                    Console.WriteLine("Notificação para o 1º grupo: Suspender atividades!");
                }
                else
                {
                    Console.WriteLine("Índice de poluição dentro dos limites aceitáveis.");
                }

                Console.WriteLine("Deseja encerrar o programa? (S/N)");
                string resposta = Console.ReadLine();

                encerrarPrograma = (resposta.ToLower() == "s");

                Console.Clear();
            }
        }
    }
}

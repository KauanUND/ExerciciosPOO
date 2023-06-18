using System;

namespace VerificarNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            bool encerrarPrograma = false;

            while (!encerrarPrograma)
            {
                Console.WriteLine("Informe um número inteiro:");
                int numero = int.Parse(Console.ReadLine());

                string paridade = (numero % 2 == 0) ? "par" : "ímpar";
                string positividade = (numero >= 0) ? "positivo" : "negativo";

                Console.WriteLine($"O número {numero} é {paridade} e {positividade}.");

                Console.WriteLine("Deseja encerrar o programa? Digite S ou N");
                string resposta = Console.ReadLine();

                encerrarPrograma = (resposta.ToLower() == "s");

                Console.Clear();
            }
        }
    }
}

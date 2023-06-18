using System;

namespace JogoAdivinhacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numeroSorteado = random.Next(101);
            int tentativas = 0;

            Console.WriteLine("Bem-vindo ao jogo de adivinhação!");
            Console.WriteLine("Tente adivinhar o número sorteado (entre 0 e 100).");

            while (true)
            {
                Console.Write("Digite o seu palpite: ");
                int palpite = int.Parse(Console.ReadLine());
                tentativas++;

                if (palpite == numeroSorteado)
                {
                    Console.WriteLine($"Parabéns! Você acertou o número sorteado em {tentativas} tentativa(s).");
                    break;
                }
                else if (palpite < numeroSorteado)
                {
                    Console.WriteLine("O número sorteado é maior. Tá quase meu lindo");
                }
                else
                {
                    Console.WriteLine("O número sorteado é menor. Tá quase meu lindo");
                }
            }
        }
    }
}

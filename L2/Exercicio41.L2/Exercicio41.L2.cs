using System;

namespace ClassificacaoNadador
{
    class Program
    {
        static void Main(string[] args)
        {
            bool encerrarPrograma = false;

            while (!encerrarPrograma)
            {
                Console.WriteLine("Informe a idade do nadador:");
                int idade = int.Parse(Console.ReadLine());

                if (idade >= 5 && idade <= 7)
                {
                    Console.WriteLine("Categoria: Infantil A");
                }
                else if (idade >= 8 && idade <= 11)
                {
                    Console.WriteLine("Categoria: Infantil B");
                }
                else if (idade >= 12 && idade <= 13)
                {
                    Console.WriteLine("Categoria: Juvenil A");
                }
                else if (idade >= 14 && idade <= 17)
                {
                    Console.WriteLine("Categoria: Juvenil B");
                }
                else if (idade >= 18)
                {
                    Console.WriteLine("Categoria: Adulto");
                }
                else
                {
                    Console.WriteLine("Idade inválida.");
                }

                Console.WriteLine("Deseja encerrar o programa? (S/N)");
                string resposta = Console.ReadLine();

                encerrarPrograma = (resposta.ToLower() == "s");

                Console.Clear();
            }
        }
    }
}

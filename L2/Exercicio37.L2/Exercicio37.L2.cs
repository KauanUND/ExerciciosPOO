using System;

namespace ConversaoBaseNumerica
{
    class Program
    {
        static void Main(string[] args)
        {
            bool voltarAoMenu = true;

            while (voltarAoMenu)
            {
                Console.WriteLine("Menu principal:");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Sair");
                Console.Write("Informe a opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        RealizarOperacao("+");
                        break;
                    case "2":
                        RealizarOperacao("-");
                        break;
                    case "3":
                        RealizarOperacao("*");
                        break;
                    case "4":
                        RealizarOperacao("/");
                        break;
                    case "5":
                        voltarAoMenu = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                if (voltarAoMenu)
                {
                    Console.Write("Deseja voltar ao menu principal? Digite S ou N: ");
                    string resposta = Console.ReadLine();

                    if (resposta.ToLower() != "s")
                    {
                        voltarAoMenu = false;
                    }
                }

                Console.Clear();
            }
        }

        static void RealizarOperacao(string operador)
        {
            Console.WriteLine($"Digite o primeiro número: ");
            double numero1 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o segundo número: ");
            double numero2 = double.Parse(Console.ReadLine());

            double resultado = 0;

            switch (operador)
            {
                case "+":
                    resultado = numero1 + numero2;
                    break;
                case "-":
                    resultado = numero1 - numero2;
                    break;
                case "*":
                    resultado = numero1 * numero2;
                    break;
                case "/":
                    resultado = numero1 / numero2;
                    break;
            }

            Console.WriteLine($"O resultado da operação {numero1} {operador} {numero2} é: {resultado}");
            Console.WriteLine();
        }
    }
}

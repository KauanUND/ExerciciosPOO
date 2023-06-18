using System;

namespace CalculadoraOpcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            char opcao;

            do
            {
                ExibirMenu();
                opcao = LerOpcao();

                switch (opcao)
                {
                    case '1':
                        ConverterCelsiusParaFahrenheit();
                        break;
                    case '2':
                        ConverterFahrenheitParaCelsius();
                        break;
                    case '3':
                        CalcularPesoIdealHomem();
                        break;
                    case '4':
                        CalcularPesoIdealMulher();
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Digite uma opção válida (1, 2, 3, 4) ou 'S' para encerrar o programa.");
                        break;
                }

                Console.WriteLine();
            } while (opcao != 'S' && opcao != 's');
        }

        static void ExibirMenu()
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Conversão de Graus Celsius em Graus Fahrenheit");
            Console.WriteLine("2 - Conversão de Graus Fahrenheit em Graus Celsius");
            Console.WriteLine("3 - Peso ideal do homem");
            Console.WriteLine("4 - Peso ideal da mulher");
            Console.WriteLine("S - Encerrar o programa");
        }

        static char LerOpcao()
        {
            Console.Write("Opção: ");
            return Console.ReadKey().KeyChar;
        }

        static void ConverterCelsiusParaFahrenheit()
        {
            Console.WriteLine("\nConversão de Graus Celsius para Graus Fahrenheit");
            Console.Write("Digite a temperatura em Graus Celsius: ");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"Temperatura em Graus Fahrenheit: {fahrenheit}");
        }

        static void ConverterFahrenheitParaCelsius()
        {
            Console.WriteLine("\nConversão de Graus Fahrenheit para Graus Celsius");
            Console.Write("Digite a temperatura em Graus Fahrenheit: ");
            double fahrenheit = double.Parse(Console.ReadLine());
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"Temperatura em Graus Celsius: {celsius}");
        }

        static void CalcularPesoIdealHomem()
        {
            Console.WriteLine("\nPeso ideal do homem");
            Console.Write("Digite a altura em metros: ");
            double altura = double.Parse(Console.ReadLine());
            double pesoIdeal = (72.7 * altura) - 58;

            Console.Write("Digite o peso atual: ");
            double pesoAtual = double.Parse(Console.ReadLine());

            if (pesoAtual < pesoIdeal)
            {
                Console.WriteLine("Você está abaixo do peso ideal.");
            }
            else if (pesoAtual > pesoIdeal)
            {
                Console.WriteLine("Você está acima do peso ideal.");
            }
            else
            {
                Console.WriteLine("Você está no peso ideal.");
            }
        }

        static void CalcularPesoIdealMulher()
        {
            Console.WriteLine("\nPeso ideal da mulher");
            Console.Write("Digite a altura em metros: ");
            double altura = double.Parse(Console.ReadLine());
            double pesoIdeal = (62.1 * altura) - 44.7;

            Console.Write("Digite o peso atual: ");
            double pesoAtual = double.Parse(Console.ReadLine());

            if (pesoAtual < pesoIdeal)
            {
                Console.WriteLine("Você está abaixo do peso ideal.");
            }
            else if (pesoAtual > pesoIdeal)
            {
                Console.WriteLine("Você está acima do peso ideal.");
            }
            else
            {
                Console.WriteLine("Você está no peso ideal.");
            }
        }
    }
}

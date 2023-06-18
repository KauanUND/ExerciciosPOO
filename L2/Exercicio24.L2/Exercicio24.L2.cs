using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro número inteiro:");
        int numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número inteiro:");
        int numero2 = int.Parse(Console.ReadLine());

        int opcao;

        do
        {
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("1 - Verificar se um dos números é múltiplo do outro");
            Console.WriteLine("2 - Verificar se os dois números são pares");
            Console.WriteLine("3 - Verificar se a média dos números é maior ou igual a 7");
            Console.WriteLine("4 - Sair");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    if (numero1 % numero2 == 0 || numero2 % numero1 == 0)
                    {
                        Console.WriteLine("Um dos números é múltiplo do outro.");
                    }
                    else
                    {
                        Console.WriteLine("Nenhum dos números é múltiplo do outro.");
                    }
                    break;
                case 2:
                    if (numero1 % 2 == 0 && numero2 % 2 == 0)
                    {
                        Console.WriteLine("Os dois números são pares.");
                    }
                    else
                    {
                        Console.WriteLine("Pelo menos um dos números não é par.");
                    }
                    break;
                case 3:
                    double media = (numero1 + numero2) / 2.0;
                    if (media >= 7)
                    {
                        Console.WriteLine("A média dos números é maior ou igual a 7.");
                    }
                    else
                    {
                        Console.WriteLine("A média dos números é menor que 7.");
                    }
                    break;
                case 4:
                    Console.WriteLine("Bye Bye");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Digite novamente.");
                    break;
            }

            Console.WriteLine();
        } while (opcao != 4);
    }
}
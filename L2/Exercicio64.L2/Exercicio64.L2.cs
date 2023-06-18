using System;

class Program {
    static int[] vetor;
    static int tamanho;

    static void Main() {
        bool sair = false;

        while (!sair) {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Carregar Vetor");
            Console.WriteLine("2 - Listar Vetor");
            Console.WriteLine("3 - Exibir apenas os números pares do vetor");
            Console.WriteLine("4 - Exibir apenas os números ímpares do vetor");
            Console.WriteLine("5 - Exibir a quantidade de números pares nas posições ímpares");
            Console.WriteLine("6 - Exibir a quantidade de números ímpares nas posições pares");
            Console.WriteLine("7 - Sair");
            Console.Write("Opção: ");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao) {
                case 1:
                    CarregarVetor();
                    break;
                case 2:
                    ListarVetor();
                    break;
                case 3:
                    ExibirPares();
                    break;
                case 4:
                    ExibirImpares();
                    break;
                case 5:
                    QuantidadeParesPosicoesImpares();
                    break;
                case 6:
                    QuantidadeImparesPosicoesPares();
                    break;
                case 7:
                    sair = true;
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void CarregarVetor() {
        Console.Write("Digite o tamanho do vetor: ");
        tamanho = int.Parse(Console.ReadLine());

        vetor = new int[tamanho];

        for (int i = 0; i < tamanho; i++) {
            Console.Write($"Digite o valor para a posição {i}: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Vetor carregado com sucesso!");
    }

    static void ListarVetor() {
        Console.WriteLine("Valores do vetor:");

        for (int i = 0; i < tamanho; i++) {
            Console.WriteLine($"Posição {i}: {vetor[i]}");
        }
    }

    static void ExibirPares() {
        Console.WriteLine("Números pares do vetor:");

        for (int i = 0; i < tamanho; i++) {
            if (vetor[i] % 2 == 0) {
                Console.WriteLine(vetor[i]);
            }
        }
    }

    static void ExibirImpares() {
        Console.WriteLine("Números ímpares do vetor:");

        for (int i = 0; i < tamanho; i++) {
            if (vetor[i] % 2 != 0) {
                Console.WriteLine(vetor[i]);
            }
        }
    }

    static void QuantidadeParesPosicoesImpares() {
        int quantidade = 0;

        for (int i = 1; i < tamanho; i += 2) {
            if (vetor[i] % 2 == 0) {
                quantidade++;
            }
        }

        Console.WriteLine($"Quantidade de números pares nas posições ímpares: {quantidade}");
    }

    static void QuantidadeImparesPosicoesPares() {
        int quantidade = 0;

        for (int i = 0; i < tamanho; i += 2) {
            if (vetor[i] % 2 != 0) {
                quantidade++;
            }
        }

        Console.WriteLine($"Quantidade de números ímpares nas posições pares: {quantidade}");
    }
}

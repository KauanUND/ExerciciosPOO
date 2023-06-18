using System;

class Program {
    static void Main() {
        int[] vetor = new int[50];

        Console.WriteLine("Digite os 50 números inteiros positivos:");

        for (int i = 0; i < 50; i++) {
            vetor[i] = Convert.ToInt32(Console.ReadLine());
        }

        int quantidadePares = 0;
        int quantidadeMultiplosDe5 = 0;

        foreach (int numero in vetor) {
            if (numero % 2 == 0) {
                quantidadePares++;
            }

            if (numero % 5 == 0) {
                quantidadeMultiplosDe5++;
            }
        }

        Console.WriteLine($"Quantidade de números pares: {quantidadePares}");
        Console.WriteLine($"Quantidade de múltiplos de 5: {quantidadeMultiplosDe5}");
    }
}

using System;

class Program {
    static void Main() {
        Console.Write("Digite a quantidade de números a serem lidos: ");
        int quantidade = int.Parse(Console.ReadLine());

        int[] numeros = new int[quantidade];

        for (int i = 0; i < quantidade; i++) {
            Console.Write($"Digite o {i+1}º número: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        int maior = numeros[0];
        int soma = 0;

        for (int i = 0; i < quantidade; i++) {
            soma += numeros[i];

            if (numeros[i] > maior) {
                maior = numeros[i];
            }
        }

        double media = (double)soma / quantidade;

        Console.WriteLine($"Média: {media}");
        Console.WriteLine($"Maior número: {maior}");
    }
}

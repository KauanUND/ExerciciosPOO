using System;

class Program {
    static void Main() {
        Console.WriteLine("Digite uma frase de até 50 caracteres:");
        string frase = Console.ReadLine();

        string fraseSemEspacos = RemoverEspacos(frase);
        int quantidadeEspacos = ContarEspacos(frase);

        Console.WriteLine($"Frase sem espaços: {fraseSemEspacos}");
        Console.WriteLine($"Quantidade de espaços em branco: {quantidadeEspacos}");
    }

    static string RemoverEspacos(string frase) {
        return frase.Replace(" ", "");
    }

    static int ContarEspacos(string frase) {
        int contador = 0;
        foreach (char caractere in frase) {
            if (caractere == ' ') {
                contador++;
            }
        }
        return contador;
    }
}

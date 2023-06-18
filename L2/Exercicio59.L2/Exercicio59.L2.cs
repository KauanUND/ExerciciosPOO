using System;

class Program {
    static void Main() {
        Console.Write("Digite o primeiro caractere (de A a Z): ");
        char primeiro = char.Parse(Console.ReadLine());

        Console.Write("Digite o segundo caractere (de A a Z): ");
        char segundo = char.Parse(Console.ReadLine());

        if (primeiro < segundo) {
            int quantidade = segundo - primeiro - 1;
            Console.WriteLine($"O número de caracteres entre '{primeiro}' e '{segundo}' é: {quantidade}");
        } else {
            Console.WriteLine("Os caracteres não estão em ordem alfabética.");
        }
    }
}

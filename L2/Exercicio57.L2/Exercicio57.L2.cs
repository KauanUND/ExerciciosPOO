using System;

class Program {
    static void Main() {
        Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine();

        Console.WriteLine("Vogais encontradas:");

        foreach (char c in frase) {
            if (IsVowel(c)) {
                Console.Write(c);
            }
        }
    }

    static bool IsVowel(char c) {
        c = char.ToLower(c);

        return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
    }
}

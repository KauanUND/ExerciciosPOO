using System;

class Program {
    static void Main() {
        Console.Write("Digite um número inteiro: ");
        int numero = int.Parse(Console.ReadLine());

        string resultado = Verifica(numero);
        Console.WriteLine(resultado);
    }

    static string Verifica(int numero) {
        if (numero % 2 == 0) {
            return "PAR";
        } else {
            return "ÍMPAR";
        }
    }
}

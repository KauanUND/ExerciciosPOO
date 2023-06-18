using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Digite o valor de A:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor de B:");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor de C:");
        int c = int.Parse(Console.ReadLine());

        if (a + b < c) {
            Console.WriteLine("A soma de A e B é menor que C.");
        } else {
            Console.WriteLine("A soma de A e B não é menor que C.");
        }
    }
}
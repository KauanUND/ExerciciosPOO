using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro número:");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        int diferenca = CalcularDiferenca(numero1, numero2);

        Console.WriteLine("Diferença entre os números e igual a: " + diferenca);
    }

    public static int CalcularDiferenca(int numero1, int numero2)
    {
        int maior = Math.Max(numero1, numero2);
        int menor = Math.Min(numero1, numero2);

        int diferenca = maior - menor;
        return diferenca;
    }
}
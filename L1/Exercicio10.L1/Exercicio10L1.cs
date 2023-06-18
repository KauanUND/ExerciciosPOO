using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o peso (em kg):");
        double peso = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a altura (em metros):");
        double altura = Convert.ToDouble(Console.ReadLine());

        double imc = CalcularIMC(peso, altura);
        string condicao = ObterCondicaoIMC(imc);

        Console.WriteLine("Seu IMC é: " + imc.ToString("F2"));
        Console.WriteLine(" A sua Condição é: " + condicao);
    }

    static double CalcularIMC(double peso, double altura)
    {
        return peso / (altura * altura);
    }

    static string ObterCondicaoIMC(double imc)
    {
        if (imc < 18.5)
            return "Abaixo do peso";
        else if (imc >= 18.5 && imc < 25)
            return "Peso normal";
        else if (imc >= 25 && imc < 30)
            return "Acima do peso";
        else
            return "Obeso";
    }
}
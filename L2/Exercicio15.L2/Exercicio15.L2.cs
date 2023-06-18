using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite a 1º nota:");
        double nota1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a 2º nota:");
        double nota2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a 3º nota:");
        double nota3 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a 4º nota:");
        double nota4 = Convert.ToDouble(Console.ReadLine());

        double media = CalcularMedia(nota1, nota2, nota3, nota4);

        Console.WriteLine("Média do aluno: " + media);

        if (media >= 7)
        {
            Console.WriteLine("Aluno aprovado!");
        }
        else
        {
            Console.WriteLine("Aluno em recuperação.");
            Console.WriteLine("Digite a nota da prova de recuperação:");
            double notaRecuperacao = Convert.ToDouble(Console.ReadLine());

            double novaMedia = (media + notaRecuperacao) / 2;

            if (novaMedia >= 7)
            {
                Console.WriteLine("Aluno aprovado na recuperação!");
            }
            else
            {
                Console.WriteLine("Aluno reprovado.");
            }

            Console.WriteLine("Nova média do aluno: " + novaMedia);
        }
    }

    public static double CalcularMedia(double nota1, double nota2, double nota3, double nota4)
    {
        double media = (nota1 + nota2 + nota3 + nota4) / 4;
        return media;
    }
}
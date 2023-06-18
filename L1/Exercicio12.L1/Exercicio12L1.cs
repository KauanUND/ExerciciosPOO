using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o número de identificação do aluno:");
        int numeroIdentificacao = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite a primeira nota:");
        double nota1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a segunda nota:");
        double nota2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a terceira nota:");
        double nota3 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a média dos exercícios:");
        double mediaExercicios = Convert.ToDouble(Console.ReadLine());

        double mediaAproveitamento = CalcularMediaAproveitamento(nota1, nota2, nota3, mediaExercicios);
        string conceito = ObterConceito(mediaAproveitamento);
        string situacao = (conceito == "A" || conceito == "B" || conceito == "C") ? "Aprovado" : "Reprovado";

        Console.WriteLine("Número de identificação do aluno: " + numeroIdentificacao);
        Console.WriteLine("Notas: " + nota1 + ", " + nota2 + ", " + nota3);
        Console.WriteLine("Média dos exercícios: " + mediaExercicios);
        Console.WriteLine("Média de aproveitamento: " + mediaAproveitamento.ToString("F2"));
        Console.WriteLine("Conceito: " + conceito);
        Console.WriteLine("Situação: " + situacao);
    }

    static double CalcularMediaAproveitamento(double nota1, double nota2, double nota3, double mediaExercicios)
    {
        return (nota1 + nota2 * 2 + nota3 * 3 + mediaExercicios) / 7;
    }

    static string ObterConceito(double mediaAproveitamento)
    {
        if (mediaAproveitamento >= 90)
            return "A";
        else if (mediaAproveitamento >= 75 && mediaAproveitamento < 90)
            return "B";
        else if (mediaAproveitamento >= 60 && mediaAproveitamento < 75)
            return "C";
        else if (mediaAproveitamento >= 40 && mediaAproveitamento < 60)
            return "D";
        else
            return "E";
    }
}
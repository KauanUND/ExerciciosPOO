using System;

class Program
{
    static void Main(string[] args)
    {
        int contadorAlunos = 0;
        double somaNotas = 0;

        Console.WriteLine("Informe os dados dos alunos:");
        Console.WriteLine("Digite um número negativo para encerrar o programa.");

        while (true)
        {
            Console.Write("Número de matrícula do aluno: ");
            int matricula = int.Parse(Console.ReadLine());

            if (matricula < 0)
                break;

            Console.Write("Nota do aluno: ");
            double nota = double.Parse(Console.ReadLine());

            contadorAlunos++;
            somaNotas += nota;
        }

        if (contadorAlunos > 0)
        {
            double media = somaNotas / contadorAlunos;
            Console.WriteLine("A média da nota dos alunos é: " + media.ToString("F2"));
        }
        else
        {
            Console.WriteLine("Nenhum aluno registrado.");
        }
    }
}
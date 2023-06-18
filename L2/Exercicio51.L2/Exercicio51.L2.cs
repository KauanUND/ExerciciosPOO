using System;

namespace CalculoMediaAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de alunos: ");
            int quantidadeAlunos = int.Parse(Console.ReadLine());

            double[] notas = new double[quantidadeAlunos];
            double somaNotas = 0;
            int alunosAcimaDeSete = 0;

            for (int i = 0; i < quantidadeAlunos; i++)
            {
                Console.Write($"Digite a nota do aluno {i + 1}: ");
                notas[i] = double.Parse(Console.ReadLine());
                somaNotas += notas[i];

                if (notas[i] > 7.0)
                {
                    alunosAcimaDeSete++;
                }
            }

            double media = somaNotas / quantidadeAlunos;

            Console.WriteLine($"A média das notas é: {media.ToString("F2")}");

            if (alunosAcimaDeSete == 0)
            {
                Console.WriteLine("Não há nenhum aluno com nota acima de 7.0");
            }
            else
            {
                Console.WriteLine($"Número de alunos com nota acima de 7.0: {alunosAcimaDeSete}");
            }
        }
    }
}

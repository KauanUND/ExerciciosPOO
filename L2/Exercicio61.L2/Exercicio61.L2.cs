using System;

class Program {
    static void Main() {
        Console.Write("Digite o valor do salário: ");
        double salario = double.Parse(Console.ReadLine());

        Console.Write("Digite o índice de reajuste (em decimal): ");
        double indiceReajuste = double.Parse(Console.ReadLine());

        double salarioAtualizado = Reajuste(salario, indiceReajuste);
        Console.WriteLine($"O salário atualizado é: R${salarioAtualizado}");
    }

    static double Reajuste(double salario, double indiceReajuste) {
        double salarioAtualizado = salario + (salario * indiceReajuste);
        return salarioAtualizado;
    }
}

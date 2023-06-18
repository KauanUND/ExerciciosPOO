using System;

class Program {
    static void Main() {
        Console.Write("Digite o valor da base do triângulo: ");
        double baseTriangulo = double.Parse(Console.ReadLine());

        Console.Write("Digite o valor da altura do triângulo: ");
        double alturaTriangulo = double.Parse(Console.ReadLine());

        double hipotenusa = Hipotenusa(baseTriangulo, alturaTriangulo);
        Console.WriteLine($"O valor da hipotenusa é: {hipotenusa}");
    }

    static double Hipotenusa(double baseTriangulo, double alturaTriangulo) {
        double hipotenusa = Math.Sqrt(Math.Pow(baseTriangulo, 2) + Math.Pow(alturaTriangulo, 2));
        return hipotenusa;
    }
}

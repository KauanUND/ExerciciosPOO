﻿using System;

class Program {
    static void Main() {
        Console.Write("Digite o valor de x: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Digite o valor de y: ");
        double y = double.Parse(Console.ReadLine());

        int quadrante = VerificaQuadrante(x, y);
        Console.WriteLine($"O ponto ({x}, {y}) está no quadrante {quadrante}.");
    }

    static int VerificaQuadrante(double x, double y) {
        if (x > 0 && y > 0) {
            return 1;
        } else if (x < 0 && y > 0) {
            return 2;
        } else if (x < 0 && y < 0) {
            return 3;
        } else if (x > 0 && y < 0) {
            return 4;
        } else {
            return 0; // Ponto está na origem (0,0)
        }
    }
}

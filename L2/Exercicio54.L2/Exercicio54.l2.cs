using System;

class Program {
    static void Main() {
        int[] A = { 1, 2, 3, 4, 5 };
        int[] B = { 4, 5, 6, 7, 8, 9, 10, 11 };

        Console.WriteLine("Elementos comuns aos vetores A e B:");

        foreach (int elementA in A) {
            foreach (int elementB in B) {
                if (elementA == elementB) {
                    Console.Write($"{elementA} ");
                    break;
                }
            }
        }

        Console.WriteLine();
    }
}

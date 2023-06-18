using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a altura:");
        double altura = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o sexo M para masculino ou F para feminino:");
        char sexo = char.ToUpper(Console.ReadLine()[0]);

        double pesoIdeal;

        if (sexo == 'M')
        {
            pesoIdeal = (72.7 * altura) - 58;
            Console.WriteLine("O peso ideal para um homem com altura {0} metros é {1} kg.", altura, pesoIdeal);
        }
        else if (sexo == 'F')
        {
            pesoIdeal = (62.1 * altura) - 44.7;
            Console.WriteLine("O peso ideal para uma mulher com altura {0} metros é {1} kg.", altura, pesoIdeal);
        }
        else
        {
            Console.WriteLine("Sexo inválido. Digite M para masculino ou F para feminino.");
        }
    }
}
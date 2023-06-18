using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o nome:");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite o sexo (F/M):");
        char sexo = Console.ReadLine().ToUpper()[0];

        Console.WriteLine("Digite o estado civil:");
        string estadoCivil = Console.ReadLine().ToUpper();

        if (sexo == 'F' && estadoCivil == "CASADA")
        {
            Console.WriteLine("Digite o tempo de casada (anos):");
            int tempoCasada = int.Parse(Console.ReadLine());

            Console.WriteLine($"A pessoa {nome} é do sexo feminino, está casada há {tempoCasada} anos.");
        }
        else
        {
            Console.WriteLine($"A pessoa {nome} não se enquadra nos critérios especificados.");
        }
    }
}

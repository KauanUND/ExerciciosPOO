using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine(i);

            if (i % 10 == 0)
            {
                Console.WriteLine("Múltiplo de 10");
            }
        }
    }
}
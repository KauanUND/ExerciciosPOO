using System;

namespace CalculoConsumoCombustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tempo gasto na viagem em horas:");
            double tempoGasto = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a velocidade média em km/h:");
            double velocidadeMedia = double.Parse(Console.ReadLine());

            double distancia = tempoGasto * velocidadeMedia;
            double litrosUsados = distancia / 12;

            Console.WriteLine($"Velocidade média: {velocidadeMedia} km/h");
            Console.WriteLine($"Tempo gasto na viagem: {tempoGasto} horas");
            Console.WriteLine($"Distância percorrida: {distancia} km");
            Console.WriteLine($"Quantidade de litros utilizada na viagem: {litrosUsados:F2} litros");
        }
    }
}
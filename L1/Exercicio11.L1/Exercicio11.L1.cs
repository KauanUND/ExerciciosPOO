using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o preço normal de etiqueta do produto:");
        double precoNormal = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Escolha a condição de pagamento:");
        Console.WriteLine("1 - À vista em dinheiro ou cheque");
        Console.WriteLine("2 - À vista no cartão de crédito");
        Console.WriteLine("3 - Em duas vezes, sem juros");
        Console.WriteLine("4 - Em duas vezes, com juros de 10%");
        int codigoCondicao = Convert.ToInt32(Console.ReadLine());

        double valorPago = CalcularValorPago(precoNormal, codigoCondicao);

        Console.WriteLine("O valor a ser pago é: R$ " + valorPago.ToString("F2"));
    }

    static double CalcularValorPago(double precoNormal, int codigoCondicao)
    {
        double valorPago = 0;

        switch (codigoCondicao)
        {
            case 1: 
                valorPago = precoNormal * 0.9;
                break;

            case 2: 
                valorPago = precoNormal * 0.85;
                break;

            case 3:
                valorPago = precoNormal;
                break;

            case 4:
                valorPago = precoNormal * 1.1;
                break;

            default:
                Console.WriteLine("Condição de pagamento inválida.");
                break;
        }

        return valorPago;
    }
}

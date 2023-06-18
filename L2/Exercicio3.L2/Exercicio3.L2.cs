using System;

namespace PagamentoComissaoVendedores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o codigo de identificação do vendedor:");
            string identificacaoVendedor = Console.ReadLine();

            Console.WriteLine("Digite o código da peça:");
            string codigoPeca = Console.ReadLine();

            Console.WriteLine("Digite o preço unitário da peça:");
            double precoUnitario = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade vendida:");
            int quantidadeVendida = int.Parse(Console.ReadLine());

            double totalVenda = precoUnitario * quantidadeVendida;
            double comissao = totalVenda * 0.05;

            Console.WriteLine($"Identificação do vendedor: {identificacaoVendedor}");
            Console.WriteLine($"Código da peça: {codigoPeca}");
            Console.WriteLine($"Preço unitário da peça: R$ {precoUnitario}");
            Console.WriteLine($"Quantidade vendida: {quantidadeVendida}");
            Console.WriteLine($"Total da venda: R$ {totalVenda}");
            Console.WriteLine($"Comissão do vendedor: R$ {comissao}");
        }
    }
}
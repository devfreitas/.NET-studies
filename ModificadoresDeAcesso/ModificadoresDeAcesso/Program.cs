using ModificadoresDeAcesso.Core;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ModificadoresDeAcesso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== Sistema de Pagamento ====");

            //Pagamento via Boleto
            IPagamento pagamentoBoleto = new PagamentoBoleto("API-KEY-1234");
            pagamentoBoleto.ProcessarPagamento(150.00m);

            //Pagamento via Cartao
            IPagamento pagamentoCartao = new PagamentoCartao("API-KEY-1234");
            decimal valorDaCompra = 301.00m;
            pagamentoCartao.ProcessarPagamento(valorDaCompra);

            Console.WriteLine("==== Sistema de Pagamento ====");
            Console.ReadKey();

        }
    }
}
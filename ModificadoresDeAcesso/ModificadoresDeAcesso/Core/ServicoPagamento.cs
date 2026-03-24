using System;
using System.Collections.Generic;
using System.Text;

// NAMESPACE: Organização lógica do código
namespace ModificadoresDeAcesso.Core
{
    // INTERFACE: O contrato que define a ação de pagar
    public interface IPagamento
    {
        void ProcessarPagamento(decimal valor);
    }

    // CLASSE BASE: Usando modificadores de acesso
    public class ServicoPagamento
    {
        // CAMEL CASE
        private string _chaveTransacao {  get; set; }

        // CONSTRUTOR: Inicializa o estado do objeto
        public ServicoPagamento(string _chaveTransacao)
        {
            // 'this' diferencia o campo do parâmetro
            this._chaveTransacao = _chaveTransacao;
        }

        // Modificador 'protected': visível apenas para esta classe e herdeiros
        protected void LogarTransacao(string mensagem)
        {
            Console.WriteLine($"[LOG - {DateTime.Now}: {mensagem}]");
        }
    }

    // PALAVRA-CHAVE 'class' e Herança/Implementação
    public class PagamentoCartao : ServicoPagamento, IPagamento
    {
        public decimal LimiteDepagamento { get; set; } = 300.00m;

        // Construtor chamando a base
        public PagamentoCartao(string _chaveTransacao) : base(_chaveTransacao)
        {

        }

        //Camel Case no parâmetro 'valor'
        public void ProcessarPagamento(decimal valor)
        {
            LogarTransacao($"Processando o pagamando R${valor} via Cartão");

            if (valor > LimiteDepagamento)
            {
                Console.WriteLine("Pagamento não aprovado!");
            }
            else 
            {
                Console.WriteLine("Pagamento aprovado com sucesso!");
            }
        }
    }

    public class PagamentoBoleto : ServicoPagamento, IPagamento
    {
        // Construtor chamando a base
        public PagamentoBoleto(string _chaveTransacao) : base(_chaveTransacao)
        {

        }

        //Camel Case no parâmetro 'valor'
        public void ProcessarPagamento(decimal valor)
        {
            LogarTransacao($"Processando o pagamando R${valor} via Boleto");
            Console.WriteLine("Pagamento aprovado com sucesso!");
        }
    }
}

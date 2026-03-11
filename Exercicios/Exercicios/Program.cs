namespace Exercicios;

using System;

class Program
{
    static void Main()
    {
        
        Console.WriteLine("\n===== VEÍCULOS =====");
        Carro carro = new Carro();
        carro.Marca = "Toyota";
        carro.Modelo = "Corolla";
        carro.Mover();

        Moto moto = new Moto();
        moto.Marca = "Honda";
        moto.Modelo = "CB500";
        moto.Mover();
        
        Console.WriteLine("===== ZOOLÓGICO =====");
        Cachorro dog = new Cachorro("Rex");
        dog.EmitirSom();

        Gato cat = new Gato("Mimi");
        cat.EmitirSom();

        
        Console.WriteLine("\n===== LOJA =====");
        ProdutoEletronico tv = new ProdutoEletronico();
        tv.Nome = "TV";
        tv.PrecoBase = 2000;
        Console.WriteLine("Desconto Eletrônico: " + tv.CalcularDesconto());

        ProdutoAlimenticio arroz = new ProdutoAlimenticio();
        arroz.Nome = "Arroz";
        arroz.PrecoBase = 100;
        Console.WriteLine("Desconto Alimento: " + arroz.CalcularDesconto());


        Console.WriteLine("\n===== BANCO =====");
        ContaCorrente cc = new ContaCorrente();
        cc.Depositar(100);
        cc.Sacar(50);
        Console.WriteLine("Saldo Conta Corrente: " + cc.MostrarSaldo());

        ContaPoupanca cp = new ContaPoupanca();
        cp.Depositar(100);
        cp.Sacar(50);
        Console.WriteLine("Saldo Conta Poupança: " + cp.MostrarSaldo());


        Console.WriteLine("\n===== FUNCIONÁRIOS =====");
        Gerente g = new Gerente();
        g.Nome = "Carlos";
        g.SalarioBase = 5000;
        Console.WriteLine("Salário Gerente: " + g.CalcularSalarioFinal());

        Desenvolvedor d = new Desenvolvedor();
        d.Nome = "Ana";
        d.SalarioBase = 4000;
        Console.WriteLine("Salário Desenvolvedor: " + d.CalcularSalarioFinal());

        Estagiario e = new Estagiario();
        e.Nome = "João";
        e.SalarioBase = 1000;
        Console.WriteLine("Salário Estagiário: " + e.CalcularSalarioFinal());
    }
}
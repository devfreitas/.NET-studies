namespace Exercicios;


using System;

class ContaBancaria
{
    protected double Saldo;

    public void Depositar(double valor)
    {
        Saldo += valor;
    }

    public virtual void Sacar(double valor)
    {
        if (valor <= Saldo)
            Saldo -= valor;
    }

    public double MostrarSaldo()
    {
        return Saldo;
    }
}

class ContaCorrente : ContaBancaria
{
    public override void Sacar(double valor)
    {
        double taxa = 5.0;
        if (valor + taxa <= Saldo)
            Saldo -= (valor + taxa);
    }
}

class ContaPoupanca : ContaBancaria
{
    public override void Sacar(double valor)
    {
        if (valor <= Saldo)
            Saldo -= valor;
        else
            Console.WriteLine("Saldo insuficiente!");
    }
}


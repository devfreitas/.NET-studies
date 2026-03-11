namespace Exercicios;

using System;

abstract class Produto
{
    public string Nome { get; set; }

    private double precoBase;
    public double PrecoBase
    {
        get { return precoBase; }
        set
        {
            if (value >= 0)
                precoBase = value;
            else
                Console.WriteLine("Preço não pode ser negativo!");
        }
    }

    public abstract double CalcularDesconto();
}

class ProdutoEletronico : Produto
{
    public override double CalcularDesconto()
    {
        return PrecoBase * 0.10;
    }
}

class ProdutoAlimenticio : Produto
{
    public override double CalcularDesconto()
    {
        return PrecoBase * 0.05;
    }
}


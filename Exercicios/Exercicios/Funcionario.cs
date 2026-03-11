namespace Exercicios;

using System;

abstract class Funcionario
{
    public string Nome { get; set; }
    public double SalarioBase { get; set; }

    public abstract double CalcularSalarioFinal();
}

class Gerente : Funcionario
{
    public override double CalcularSalarioFinal()
    {
        return SalarioBase + (SalarioBase * 0.20);
    }
}

class Desenvolvedor : Funcionario
{
    public override double CalcularSalarioFinal()
    {
        return SalarioBase + (SalarioBase * 0.10);
    }
}

class Estagiario : Funcionario
{
    public override double CalcularSalarioFinal()
    {
        return SalarioBase + 150;
    }
}

namespace Exercicios;

using System;

abstract class Veiculo
{
    // Encapsulamento
    public string Marca { get; set; }
    public string Modelo { get; set; }

    // Abstração
    public abstract void Mover();
}

class Carro : Veiculo
{
    public override void Mover()
    {
        Console.WriteLine("O carro está dirigindo nas 4 rodas");
    }
}

class Moto : Veiculo
{
    public override void Mover()
    {
        Console.WriteLine("A moto está acelerando em 2 rodas");
    }
}

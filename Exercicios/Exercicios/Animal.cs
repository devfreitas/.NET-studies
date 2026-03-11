namespace Exercicios;

using System;

class Animal
{
    public string Nome { get; private set; }

    public Animal(string nome)
    {
        Nome = nome;
    }

    public virtual void EmitirSom()
    {
        Console.WriteLine("O animal fez um som");
    }
}

class Cachorro : Animal
{
    public Cachorro(string nome) : base(nome) { }

    public override void EmitirSom()
    {
        Console.WriteLine("Au au!");
    }
}

class Gato : Animal
{
    public Gato(string nome) : base(nome) { }

    public override void EmitirSom()
    {
        Console.WriteLine("Miau!");
    }
}

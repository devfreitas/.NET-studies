using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProgramaPOO.Domain.Entities
{
    //(Classe Abstrata - Abstração)
    public abstract class Produto
    {
        // ORACLE    Guid : eb2d6e10-9fdb-49af-a8b6-60a678e16c3f, Nome: Amortecedor, PrecoBase: 100.00
        // Postgress Guid : 15a7b6af-47ec-4aeb-b4ea-732a158eb062, Nome: Lampadas de Led Moto, PrecoBase: 40.00

        public Guid Id { get; protected set; } // Encapsulamento
        public string Nome { get; protected set; } // Encapsulamento
        public decimal PrecoBase { get; protected set; } // Encapsulamento

        public Produto(string nome,decimal precoBase)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            PrecoBase = precoBase;
        }

        // Polimorfismo:
        public abstract decimal CalcularAluguel(int dias);
    }
}

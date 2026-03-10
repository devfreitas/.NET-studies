using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProgramaPOO.Domain.Entities
{
    //(Herança)
    public class Livro : Produto
    {
        public string Autor { get; set; }

        public Livro(string nome,decimal preco,string autor)
            : base(nome,preco)
        {
            Autor = autor;
        }

        public override decimal CalcularAluguel(int dias)
        {
            return dias * PrecoBase;
        }
    }
}

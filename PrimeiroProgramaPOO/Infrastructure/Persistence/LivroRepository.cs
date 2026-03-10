using PrimeiroProgramaPOO.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProgramaPOO.Infrastructure.Persistence
{
    public class LivroRepository
    {
        private readonly List<Livro> livros = new();

        public void Adicionar(Livro livro)
        {
            livros.Add(livro);
        }

        //// Mesmo metodo de adicionar porem, com retorno da lista de livros
        //public List<Livro> Adicionar(Livro livro)
        //{
        //    livros.Add(livro);
        //    return livros;
        //}

        public IEnumerable<Livro> ObterTodos()
        {
            return livros;
        }
    }
}

using PrimeiroProgramaPOO.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeiroProgramaPOO
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        }
    }
}












//Pessoa
//Animal
//------------------------------------------------------------------------------------------------------------------------------
// 4 pilares da POO + 1
// Herança > Classes > Animal (Nome,Idade)
// (Cachorro(Nome,Idade),Focinho
// Gato(Nome,Idade)     ,Sem Pele
// Vaca(Nome,Idade)     ,Leiteira
// Cavalo(Nome,Idade)   ,Crina
// Gavião(Nome,Idade)   ,Asas

//Produto > Nome,Preco,Unidade
//Amortecedores
//Farol
//Oleos
//Livro
// ...)
//------------------------------------------------------------------------------------------------------------------------------
// Abstração
// Produto (Abstração) - CalcularAluguel(int dias)

// Livro > Todo livro ele é um Produto, porem, todavia, entretando, nem todo produto é um livro.
// CalcularAluguel(int dias) > dias * preco * 0.1 (10% do valor do produto por dia que não devolver)

// Canetas> Todo Caneta ele é um Produto, porem, todavia, entretando, nem todo produto é um Caneta.
// CalcularAluguel(int dias)

// Carro> Todo Carro ele é um Produto, porem, todavia, entretando, nem todo produto é um Carro.
// CalcularAluguel(int dias) > dias * preco * 0.5 (50% do valor do produto por dia que não devolver)

//Database()
//Database().insert(Livro)
//Database().insert(Canetas)
//Database().insert(Carro)
//------------------------------------------------------------------------------------------------------------------------------

// Polimorfismo
// Classes > Animal (Nome,Idade) > Falar() > "O animal faz um som"
// Cachorro(Nome,Idade),Focinho > Falar() > "O cachorro late"
// Gato(Nome,Idade)     ,Sem Pele Falar() > "O gato mia"
// Vaca(Nome,Idade)     ,Leiteira Falar() > "A vaca muge"
// Cavalo(Nome,Idade)   ,Crina Falar() > "O cavalo relincha"
// Gavião(Nome,Idade)   ,Asas > Falar() > "O gavião grita"

//------------------------------------------------------------------------------------------------------------------------------
// Encapsulamento
// Produto > Nome,Preco,Unidade > PRIVATE CalcularTaxaFixa() > 10% do valor do produto CalcularPreco()
// Amortecedores > CalcularPreco()
// Farol > CalcularPreco()
// Oleos > CalcularPreco()
// ...)
//public: sem restrições no acesso
//internal: restrito ao assembly onde está contido
//protected: restrito a class que o contém e a quaisquer classes derivadas
//protected internal: lógica OU para o internal e protected.
//private: restrito a classe que o contém

// Extra > Classes e dos objetos
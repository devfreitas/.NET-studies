using System;
using System.Collections.Generic;
using System.Globalization;

namespace MeuPrimeiroPrograma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========================");
            Console.WriteLine("Sistema de Gestão Academica v1");
            Console.WriteLine("===========================");
            Console.WriteLine();

            Console.Write("Digite o nome do aluno: ");
            string Nome = Console.ReadLine();

            Console.Write("Digite a nota do Checkpoint 1: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a nota do Checkpoint 2: ");
            double nota2 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2) / 2;

            //SE media do aluno for maior ou igual a 7 aluno aprovado 
            if (media >= 7)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Aluno aprovado!");
            }
            else // se não aluno reprovado
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Aluno Reprovado!");
            }

            Console.ResetColor();

            Console.WriteLine("======================");
            Console.ReadKey();
            
            Console.WriteLine("Sua média final é " + media);
            Console.WriteLine($"Sua média final é {media:F2}");
            Console.WriteLine("Sua média final é " + media.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
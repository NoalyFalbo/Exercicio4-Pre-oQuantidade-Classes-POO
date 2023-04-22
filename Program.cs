using System;
using System.Globalization;

namespace exercicioClasses4
{

  class Program
  {

    static void Main(string[] args)
    {

      Console.Clear();

      Produto p = new Produto();


      Console.WriteLine("Digite os dados do produto: ");
      Console.Write("Nome: ");
      p.Nome = Console.ReadLine();
      Console.WriteLine("Preço");
      p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      Console.WriteLine("Quantidade: no estoque: ");
      p.Quantidade = int.Parse(Console.ReadLine());

      Console.WriteLine("Dados do Produto: " + p);


    }
  }
}
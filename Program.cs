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
      Console.WriteLine("Quantidade no estoque: ");
      p.Quantidade = int.Parse(Console.ReadLine());

      Console.WriteLine("Dados do Produto: " + p);

      Console.WriteLine();

      Console.WriteLine("Digite o número de produtos a ser adicionado no estoque:");
      int qnt = int.Parse(Console.ReadLine());
      p.AdicionarProdutos(qnt);
      Console.WriteLine("Dados atualizados: " + p);

      Console.WriteLine();

      Console.WriteLine("Digite o número de produtos a ser removido no estoque:");
      qnt = int.Parse(Console.ReadLine());
      p.RemoverProdutos(qnt);
      Console.WriteLine("Dados atualizados: " + p);

    }
  }
}
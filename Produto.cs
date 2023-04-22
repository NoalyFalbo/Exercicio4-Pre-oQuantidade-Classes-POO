using System.Globalization;

namespace exercicioClasses4
{
  public class Produto
  {

    public string Nome;
    public double Preco;
    public int Quantidade;
    public double ValorTotalEmEstoque()
    {
      return Preco * Quantidade;
    }
    public override string ToString()
    {
      return Nome
      + ", $ "
      + Preco.ToString("F2", CultureInfo.InvariantCulture)
      + ", "
      + Quantidade
      + " uniades, Total: $ "
      + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
    }
  }
}
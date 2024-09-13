namespace SOLID.OCP;

public class ProdutoCorretoOCP
{
    public int Id { get; private set; }
    public string Nome { get; private set; }
    public decimal Custo { get; private set; }
    public decimal ValorVenda { get; private set; }

    public ProdutoCorretoOCP(int id, string nome)
    {
        Id = id;
        Nome = nome;
    }

    public void SetCusto(decimal custo)
    {
        if (custo > 0)
            Custo = custo;
    }

    public void SetValorVenda(decimal valorVenda)
    {
        if (valorVenda > 0)
            ValorVenda = valorVenda;
    }
}

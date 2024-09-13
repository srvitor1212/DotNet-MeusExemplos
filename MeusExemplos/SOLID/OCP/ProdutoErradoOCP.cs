namespace SOLID.OCP;

public class ProdutoErradoOCP
{
    public int Id { get; private set; }
    public string Nome { get; private set; }
    public decimal Custo { get; private set; }
    public decimal ValorVenda { get; private set; }

    public ProdutoErradoOCP(int id, string nome)
    {
        Id = id;
        Nome = nome;
    }

    public void SetCusto(decimal custo)
    {
        if (custo > 0)
            ValorVenda = custo;
    }

    public void SetValorVenda(decimal valorVenda)
    {
        if (valorVenda > 0)
            ValorVenda = valorVenda;
    }



    /* 
     * Imaginando que o método abaixo é um novo requisito de negócio.
     * 
     * Ao implementar essa funcionalidade na classe já existente, testar outras funcionalidades será necessário.
     * 
     * Ferindo o princípio que a classe deve estar fechada para modificação e aberta para extenção.
     */
    public double MargemLucro()
    {
        try
        {
            var liquido = ValorVenda - Custo;
            return Convert.ToDouble( liquido/ValorVenda * 100 );
        }
        catch (Exception e)
        {
            Console.WriteLine($"Erro ao calcular: {e}");
            return 0;
        }
    }
}

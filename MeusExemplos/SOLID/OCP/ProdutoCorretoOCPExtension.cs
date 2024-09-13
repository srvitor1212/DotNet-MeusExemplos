namespace SOLID.OCP;


//classe static
public static class ProdutoCorretoOCPExtension
{

    //método static e palavra this
    //ao usar a palavra this, a classe ProdutoCorretoOCP entende que esse método faz parte dela
    public static double MargemLucro(this ProdutoCorretoOCP produto)
    {
        try
        {
            var liquido = produto.ValorVenda - produto.Custo;
            return Convert.ToDouble(liquido / produto.ValorVenda * 100);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Erro ao calcular: {e}");
            return 0;
        }
    }
}

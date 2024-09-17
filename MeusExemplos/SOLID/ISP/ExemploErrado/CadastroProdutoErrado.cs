namespace SOLID.ISP.ExemploErrado;

public class CadastroProdutoErrado : IPersistirErrado
{

    // Não deveria ser necesário implementar essa interface para cadastro de produto
    public string EnviarEmail() => throw new NotImplementedException();

    public string SalvarDataBase() => "Produto > Salvo no DB";

    public string ValidarDados() => "Produto > Dados validados";
}

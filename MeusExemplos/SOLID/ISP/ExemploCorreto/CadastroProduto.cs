namespace SOLID.ISP.ExemploCorreto;

public class CadastroProduto : IPersistir
{
    public string SalvarDataBase() => "Produto > Salvo no DB";

    public string ValidarDados() => "Produto > Dados validados";
}

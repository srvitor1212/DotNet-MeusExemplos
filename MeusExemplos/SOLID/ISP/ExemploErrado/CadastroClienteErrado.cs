namespace SOLID.ISP.ExemploErrado;

public class CadastroClienteErrado : IPersistirErrado
{
    public string EnviarEmail() => "Cliente > Email enviado";

    public string SalvarDataBase() => "Cliente > Salvo no DB";

    public string ValidarDados() => "Cliente > Dados validados";
}

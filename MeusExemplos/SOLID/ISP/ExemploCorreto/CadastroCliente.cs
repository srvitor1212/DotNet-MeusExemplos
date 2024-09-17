namespace SOLID.ISP.ExemploCorreto;

public class CadastroCliente : IPersistir, IEmail
{
    public string EnviarEmail() => "Cliente > enviar email";

    public string SalvarDataBase() => "Cliente > Salvo no DB";

    public string ValidarDados() => "Cliente > Dados validados";
}

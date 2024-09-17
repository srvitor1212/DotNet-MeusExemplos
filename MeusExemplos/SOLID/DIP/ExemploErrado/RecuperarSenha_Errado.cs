namespace SOLID.DIP.ExemploErrado;

public class RecuperarSenha_Errado
{
    private ConexaoSqlServer_Errado _conexaoSqlServer_Errado;

    public void RecuperarSenha()
    {
        /* Aqui fere o princiío de inversão de dependência pois a classe "RecuperarSenha_Errado"
         está responável por criar uma instâcia da conexão de banco de dados 
        
         Esse código fere também: OCP e SRP */
        _conexaoSqlServer_Errado = new ConexaoSqlServer_Errado();

        _conexaoSqlServer_Errado.Conectar();

        Console.WriteLine("Senha recuperada com sucesso!");
    }
}

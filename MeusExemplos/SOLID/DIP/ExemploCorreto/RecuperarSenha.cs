namespace SOLID.DIP.ExemploCorreto;

public class RecuperarSenha
{
    private IConexao _conexaoSqlServer;


    /* Aqui no construtor está injetando uma dependência de "IConexao" sendo que "ConexaoSqlServer" é também do tipo "IConexao"
     portanto ao instânciar a classe "RecuperarSenha" vamos passar dai "ConexaoSqlServer" */
    public RecuperarSenha(IConexao conexaoSqlServer) 
    {
        _conexaoSqlServer = conexaoSqlServer;
    }

    public void Recuperar()
    {
        _conexaoSqlServer.Conectar();

        Console.WriteLine("Senha recuperada com sucesso!");
    }
}

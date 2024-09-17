using System.Threading.Channels;

namespace SOLID.DIP.ExemploCorreto;

public class ConexaoSqlServer : IConexao
{
    public void Conectar()
    {
        Console.WriteLine("Conectou com o banco");
    }
}

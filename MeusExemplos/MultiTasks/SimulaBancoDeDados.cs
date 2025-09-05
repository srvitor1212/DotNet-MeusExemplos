

namespace Tasks;


public class SimulaBancoDeDados
{
    public int Seconds { get; set; }

    public async Task<string> Consultar(int seconds, Guid taskId)
    {
        var id = Guid.NewGuid();
        Log.Write(id, "SimulaBancoDeDados inicio");




        Seconds = seconds;
        var rand = new Random();

        for (long i = 0; i < 2_000_000_000; i++)
            rand.Next();

        var t = Thread.CurrentThread;




        Log.Write(id, "SimulaBancoDeDados fim");
        return "RESULTADO DA CONSULTA";
    }
}



namespace Tasks;


public class SimulaBancoDeDados
{
    public int Seconds { get; set; }

    public async Task<string> Consultar(int seconds, Guid taskId)
    {
        Seconds = seconds;

        var rand = new Random();

        await Task.Delay(0);

        /* Se usar task.delay não ocupa CPU nem cria thread nova.
         Ele agenda um timer no sistema operacional, e quando o tempo expira, 
        o runtime volta a executar a continuação (o resto do método async) usando o ThreadPool.*/
        for (long i = 0; i < 2_000_000_000; i++)
            rand.Next();


        var t = Thread.CurrentThread;

        Console.WriteLine($"{DateTime.Now} | {t.ManagedThreadId} {t.Name} | {GetType()} | taskid={taskId} - Terminou");

        return "RESULTADO DA CONSULTA";
    }
}

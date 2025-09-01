

namespace Tasks;


public class SimulaBancoDeDados
{
    public int Seconds { get; set; }

    public async Task<string> Consultar(int seconds, Guid taskId)
    {
        Seconds = seconds;

        await Task.Delay(Seconds * 1000);

        var t = Thread.CurrentThread;

        Console.WriteLine($"{DateTime.Now} | {t.Name} | {GetType()} | taskid={taskId} - Terminou");

        return "RESULTADO DA CONSULTA";
    }
}

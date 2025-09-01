

namespace Tasks;

public class Tarefa
{
    public int Delay { get; set; } = 3;

    public async Task Executar(Guid taskId)
    {
        var t = Thread.CurrentThread;
        Console.WriteLine($"{DateTime.Now} | {t.ManagedThreadId} {t.Name} | {GetType()} | {taskId} - Iniciou");



        var db = new SimulaBancoDeDados();
        var result = await db.Consultar(Delay, taskId);



        Console.WriteLine($"{DateTime.Now} | {t.ManagedThreadId} {t.Name} | {GetType()} | {taskId} - Terminou");
    }
}

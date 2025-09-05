

namespace Tasks;


public class SimulaBancoDeDados
{
    public int Seconds { get; set; }

    public async Task<string> Consultar(int seconds, Guid taskId)
    {
        Seconds = seconds;
        var rand = new Random();
        var t = Thread.CurrentThread;
        Console.WriteLine($"{DateTime.Now} | {t.ManagedThreadId} {t.Name} | {GetType()} | taskid={taskId} - SimulaBancoDeDados Inicio");





        /* Operações do tipo CPU-Bound libera a thread principal e geram novas threads
         Operações do tipo I/O libera a thread principal e geram novas threads. Exemplo: consulta no banco, request http*/
        for (long i = 0; i < 900_000_000; i++)
            rand.Next();
        t = Thread.CurrentThread;
        Console.WriteLine($"{DateTime.Now} | {t.ManagedThreadId} {t.Name} | {GetType()} | taskid={taskId} - Terminou CPU-Bound");

        await Task.Delay(1);
        t = Thread.CurrentThread;
        Console.WriteLine($"{DateTime.Now} | {t.ManagedThreadId} {t.Name} | {GetType()} | taskid={taskId} - Terminou I/O");






        t = Thread.CurrentThread;
        Console.WriteLine($"{DateTime.Now} | {t.ManagedThreadId} {t.Name} | {GetType()} | taskid={taskId} - SimulaBancoDeDados Terminou");
        return "RESULTADO DA CONSULTA";
    }
}

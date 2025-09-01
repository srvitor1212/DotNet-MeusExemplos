namespace ConsoleApp3;

public class Tarefa
{
    public Guid Id { get; set; }

    public async Task<string> Executar(int seconds)
    {
        Id = Guid.NewGuid();
        var t = Thread.CurrentThread;

        Console.WriteLine($"{DateTime.Now} | {t.ManagedThreadId} {t.Name} | {Id} - Tarefa - Iniciou");

        await Task.Delay(seconds * 1000);

        Console.WriteLine($"{DateTime.Now} | {t.ManagedThreadId} {t.Name} | {Id} - Tarefa - Terminou");


        return "FIM DA TAREFA";
    }
}

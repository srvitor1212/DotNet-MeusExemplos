namespace ConsoleApp3;

public class Tarefa
{
    public Guid Id { get; set; }

    public async Task<string> Executar()
    {
        var start = DateTime.Now;
        Id = Guid.NewGuid();
        var t = Thread.CurrentThread;
        var rand = new Random();

        Console.WriteLine($"{DateTime.Now} | {t.ManagedThreadId} {t.Name} | {Id} - Tarefa - Iniciou");


        var t1 = Task.Run(() =>
        {
            Console.WriteLine($"{DateTime.Now} | {t.ManagedThreadId} {t.Name} | {Id} - Sub-Tarefa 1 - inicio");
            for (long i = 0; i < 999_000_000; i++)
                rand.Next();
            Console.WriteLine($"{DateTime.Now} | {t.ManagedThreadId} {t.Name} | {Id} - Sub-Tarefa 1 - Terminou");
        });

        var t2 = Task.Run(() =>
        {
            Console.WriteLine($"{DateTime.Now} | {t.ManagedThreadId} {t.Name} | {Id} - Sub-Tarefa 2 - inicio");
            for (long i = 0; i < 500_000_000; i++)
                rand.Next();
            Console.WriteLine($"{DateTime.Now} | {t.ManagedThreadId} {t.Name} | {Id} - Sub-Tarefa 2 - Terminou");
        });

        var t3 = Task.Run(() =>
        {
            Console.WriteLine($"{DateTime.Now} | {t.ManagedThreadId} {t.Name} | {Id} - Sub-Tarefa 3 - inicio");
            for (long i = 0; i < 100_000_000; i++)
                rand.Next();
            Console.WriteLine($"{DateTime.Now} | {t.ManagedThreadId} {t.Name} | {Id} - Sub-Tarefa 3 - Terminou");
        });

        await Task.WhenAll(t1, t2, t3);

        var end = DateTime.Now;

        Console.WriteLine($"{DateTime.Now} | {t.ManagedThreadId} {t.Name} | {Id} - Tarefa - Terminou {end - start}");

        return "FIM DA TAREFA";
    }
}

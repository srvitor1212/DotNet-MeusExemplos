using Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        var t = Thread.CurrentThread;
        t.Name = "[Chamador_Na_Main]";
        Console.WriteLine($"{DateTime.Now} | {t.ManagedThreadId} {t.Name} | Main - Iniciou");


        /*Dessa forma todas as task rodam na mesma thread, sem existir paralelismo*/
        var tarefas = new[]
        {
            new Tarefa { Delay = 8 }.Executar(Guid.NewGuid()),
            new Tarefa { Delay = 2 }.Executar(Guid.NewGuid()),
            new Tarefa { Delay = 3 }.Executar(Guid.NewGuid())
        };
        await Task.WhenAll(tarefas);

        /*Dessa forma cada task vai alocar sua própria thread, permitindo um processo paralelo*/
        Console.WriteLine($"\n\n\n --- Com paralelismo ---");
        var t1 = Task.Run(() => new Tarefa { Delay = 8 }.Executar(Guid.NewGuid()));
        var t2 = Task.Run(() => new Tarefa { Delay = 8 }.Executar(Guid.NewGuid()));
        var t3 = Task.Run(() => new Tarefa { Delay = 8 }.Executar(Guid.NewGuid()));

        await Task.WhenAll(t1, t2, t3); // garante que a thread principal vai esperar as demais

        Console.WriteLine($"{DateTime.Now} | {t.ManagedThreadId} {t.Name} | Main - Terminou");
    }
}
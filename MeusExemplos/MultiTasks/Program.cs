using Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        var t = Thread.CurrentThread;
        t.Name = "[Chamador_Na_Main]";
        Console.WriteLine($"{DateTime.Now} | {t.ManagedThreadId} {t.Name} | Main - Iniciou");


        var tarefas = new[]
        {
            new Tarefa { Delay = 8 }.Executar(Guid.NewGuid()),
            new Tarefa { Delay = 2 }.Executar(Guid.NewGuid()),
            new Tarefa { Delay = 3 }.Executar(Guid.NewGuid())
        };

        await Task.WhenAll(tarefas);


        Console.WriteLine($"{DateTime.Now} | {t.ManagedThreadId} {t.Name} | Main - Terminou");
    }
}
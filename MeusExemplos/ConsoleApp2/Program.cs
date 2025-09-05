

namespace Tasks;


class Program
{
    static async Task Main(string[] args)
    {
        var t = Thread.CurrentThread;
        t.Name = "[Chamador_Na_Main]";
        Console.WriteLine($"{DateTime.Now} | {t.ManagedThreadId} {t.Name} | Main - Iniciou");


        var task1 = new Tarefa();
        await task1.Executar(Guid.NewGuid());


        Console.WriteLine($"{DateTime.Now} | {t.ManagedThreadId} {t.Name} | Main - Terminou");
    }
}
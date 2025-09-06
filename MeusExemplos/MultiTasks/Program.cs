using Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        var id = Guid.NewGuid();
        Log.Write(id, "Main inicio");




        /*Dessa forma todas as task rodam na mesma thread, sem existir paralelismo*/
        var tarefas = new[]
        {
            new Tarefa { }.Executar(Guid.NewGuid()),
            new Tarefa { }.Executar(Guid.NewGuid()),
            new Tarefa { }.Executar(Guid.NewGuid())
        };
        Log.Write(id, "Main fim parcial");



        /*Dessa forma cada task vai ser alocada em uma nova thread, permitindo um processo paralelo*/
        Console.WriteLine($"\n\n\n --- Com paralelismo ---");
        var t1 = Task.Run(() => new Tarefa { }.Executar(Guid.NewGuid()));
        var t2 = Task.Run(() => new Tarefa { }.Executar(Guid.NewGuid()));
        var t3 = Task.Run(() => new Tarefa { }.Executar(Guid.NewGuid()));

        await Task.WhenAll(t1, t2, t3); // garante que a thread principal vai esperar as demais





        Log.Write(id, "Main fim");
    }
}
using MultiThreadAndTasks;

namespace ConsoleApp3;

public class Tarefa
{
    public Guid Id { get; set; }

    public async Task<string> Executar()
    {
        var idTarefa = Guid.NewGuid();
        Log.Write(idTarefa, "Tarefa Inicio");
        var start = DateTime.Now;
        var rand = new Random();


        var t1 = Task.Run(() =>
        {
            var id = Guid.NewGuid();
            Log.Write(id, "SubTask t1 - inicio");

            for (long i = 0; i < 1_600_000_000; i++)
                rand.Next();

            Log.Write(id, "SubTask t1 - fim");
        });

        var t2 = Task.Run(() =>
        {
            var id = Guid.NewGuid();
            Log.Write(id, "SubTask t2 - inicio");

            for (long i = 0; i < 800_000_000; i++)
                rand.Next();

            Log.Write(id, "SubTask t2 - fim");
        });

        var t3 = Task.Run(() =>
        {
            var id = Guid.NewGuid();
            Log.Write(id, "SubTask t3 - inicio");

            for (long i = 0; i < 100_000_000; i++)
                rand.Next();

            Log.Write(id, "SubTask t3 - inicio");
        });


        Log.Write(idTarefa, $"O await agora libera essa thread...");
        await Task.WhenAll(t1, t2, t3);


        var end = DateTime.Now;
        Log.Write(idTarefa, $"Tarefa Fim {end-start}");
        return "FIM DA TAREFA";
    }
}

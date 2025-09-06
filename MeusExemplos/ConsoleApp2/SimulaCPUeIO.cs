

namespace LogApiTasks;


public class SimulaCPUeIO
{
    public int Seconds { get; set; }

    public async Task<string> Consultar(int seconds, Guid taskId)
    {
        Seconds = seconds;
        var rand = new Random();
        var id = Guid.NewGuid();
        Log.Write(id, "SimulaCPUeIO inicio");





        /* Operações do tipo CPU-Bound NÃO libera a thread principal e NÃO geram novas threads
         * Operações do tipo I/O libera a thread principal e geram novas threads. Exemplo: consulta no banco, request http*/
        for (long i = 0; i < 900_000_000; i++)
            rand.Next();
        Log.Write(id, "Terminou o CPU-Bound!");

        await Task.Delay(1);
        Log.Write(id, "Terminou o I/O!");

        for (long i = 0; i < 900_000_000; i++)
            rand.Next();
        Log.Write(id, "Terminou o CPU-Bound na nova thread!");







        Log.Write(id, "SimulaCPUeIO fim");
        return "RESULTADO DA CONSULTA";
    }
}



namespace LogApiTasks;


public class SimulaTarefaPesada
{
    public int Seconds { get; set; }

    public async Task<string> Consultar(int seconds, Guid taskId)
    {
        Seconds = seconds;
        var rand = new Random();
        var id = Guid.NewGuid();
        Log.Write(id, "SimulaTarefaPesada inicio");





        for (long i = 0; i < 2_000_000_000; i++)
            rand.Next();




        Log.Write(id, "SimulaTarefaPesada fim");
        return "RESULTADO DA CONSULTA";
    }
}

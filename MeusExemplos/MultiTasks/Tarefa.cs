

namespace Tasks;

public class Tarefa
{
    public int Delay { get; set; } = 3;

    public async Task Executar(Guid taskId)
    {
        var id = Guid.NewGuid();
        Log.Write(id, "Tarefa inicio");



        var process = new SimulaTarefaPesada();
        var result = await process.Consultar(Delay, taskId);



        Log.Write(id, "Tarefa fim");
    }
}

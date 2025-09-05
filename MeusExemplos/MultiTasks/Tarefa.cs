

namespace Tasks;

public class Tarefa
{
    public int Delay { get; set; } = 3;

    public async Task Executar(Guid taskId)
    {
        var id = Guid.NewGuid();
        Log.Write(id, "Tarefa inicio");



        var db = new SimulaBancoDeDados();
        var result = await db.Consultar(Delay, taskId);



        Log.Write(id, "Tarefa fim");
    }
}

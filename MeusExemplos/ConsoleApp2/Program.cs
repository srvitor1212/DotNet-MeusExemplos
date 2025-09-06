

namespace Tasks;


class Program
{
    static async Task Main(string[] args)
    {
        var id = Guid.NewGuid();
        Log.Write(id, "Main inicio");


        var task1 = new Tarefa();
        await task1.Executar(Guid.NewGuid());


        Log.Write(id, "Main fim");
    }
}
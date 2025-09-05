

using ConsoleApp3;
using MultiThreadAndTasks;

namespace MeuNameSpace;

class Program
{
    static void Main(string[] args)
    {
        var id = Guid.NewGuid();
        var start = DateTime.Now;
        Log.Write(id, "Main - inicio");


        var threadUm =
            new Thread(() =>
                {
                    var tarefa = new Tarefa();
                    tarefa.Executar().GetAwaiter().GetResult();
                })
            { Name = "thread um  " };

        var threadDois =
            new Thread(() =>
                {
                    var tarefa = new Tarefa();
                    tarefa.Executar().GetAwaiter().GetResult();
                })
            { Name = "thread dois" };

        var threadTres =
            new Thread(() =>
                {
                    var tarefa = new Tarefa();
                    tarefa.Executar().GetAwaiter().GetResult();
                })
            { Name = "thread tres" };


        threadUm.Start();
        threadDois.Start();
        threadTres.Start();

        // Join faz a Thread que disparou aguardar as demais.
        //threadUm.Join();
        //threadDois.Join();
        //threadTres.Join();

        var end = DateTime.Now;
        Log.Write(id, $"Main - fim {end-start}");
    }
}
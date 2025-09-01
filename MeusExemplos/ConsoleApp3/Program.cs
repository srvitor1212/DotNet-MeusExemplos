

using ConsoleApp3;

namespace MeuNameSpace;

class Program
{
    static void Main(string[] args)
    {
        var t = Thread.CurrentThread;
        t.Name = "[Chamador_Na_Main]";
        Console.WriteLine($"{DateTime.Now} | {t.ManagedThreadId} {t.Name} | Main - Iniciou");


        var threadUm =
            new Thread(() =>
                {
                    var tarefa = new Tarefa();
                    tarefa.Executar(12).GetAwaiter().GetResult();
                })
            { Name = "thread um" };

        var threadDois =
            new Thread(() =>
                {
                    var tarefa = new Tarefa();
                    tarefa.Executar(2).GetAwaiter().GetResult();
                })
            { Name = "thread dois" };

        var threadTres =
            new Thread(() =>
                {
                    var tarefa = new Tarefa();
                    tarefa.Executar(4).GetAwaiter().GetResult();
                })
            { Name = "thread tres" };


        threadUm.Start();
        threadDois.Start();
        threadTres.Start();

        // Join para aguardar o término das threads
        threadUm.Join();
        threadDois.Join();
        threadTres.Join();


        Console.WriteLine($"{DateTime.Now} | {t.ManagedThreadId} {t.Name} | Main - Terminou");
    }
}
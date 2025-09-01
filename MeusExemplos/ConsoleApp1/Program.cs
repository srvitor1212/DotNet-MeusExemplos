

Console.WriteLine($"" +
    $"--- CurrentThread info ---\n" +
    $"Name..............: {Thread.CurrentThread.Name}\n" +
    $"ThreadState.......: {Thread.CurrentThread.ThreadState}\n" +
    $"ManagedThreadId...: {Thread.CurrentThread.ManagedThreadId}\n" +
    $"Priority..........: {Thread.CurrentThread.Priority}\n" +
    $"IsAlive...........: {Thread.CurrentThread.IsAlive}\n" +
    $"IsBackground......: {Thread.CurrentThread.IsBackground}\n");

var currThread = Thread.CurrentThread;

currThread.Name = "t - 1";

Console.WriteLine($"{currThread.Name} | {Thread.CurrentThread.Name}");

//-----------------------------------------------------------------------------------------------------

var novaThread = new Thread(() =>
    {
        Console.WriteLine($"Função execudata dentro da thread{Thread.CurrentThread.Name}");
    });

novaThread.Name = "nova thread";

novaThread.Start();
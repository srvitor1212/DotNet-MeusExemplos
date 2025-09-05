namespace MultiThreadAndTasks;

public static class Log
{
    public static void Write(Guid guid, string name = "")
    {
        var t = Thread.CurrentThread;
        Console.WriteLine($"" +
            $"{DateTime.UtcNow};" +
            $"{t.ManagedThreadId,-3};" +
            $"{t.Name,-16};" +
            $"{guid};" +
            $"{name,-20};"
            );

    }
}

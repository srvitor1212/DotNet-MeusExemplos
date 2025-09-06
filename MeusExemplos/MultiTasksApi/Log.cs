namespace LogApiTasks;

public static class Log
{
    public static void Write(Guid guid, string name = "", bool end = false)
    {
        var t = Thread.CurrentThread;
        Console.WriteLine($"" +
            $"{DateTime.UtcNow};" +
            $"{t.ManagedThreadId,-3};" +
            $"{t.Name,-16};" +
            $"{guid};" +
            $"{name,-20};" +
            $"{(end ? "\n\n" : "")}"
            );

    }
}

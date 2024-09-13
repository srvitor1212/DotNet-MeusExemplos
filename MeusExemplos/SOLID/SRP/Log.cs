using SOLID.SRP.Interface;

namespace SOLID.SRP;

public class Log : ILog
{
    public bool GravarLog()
    {
        Console.WriteLine("Gravou o log");
        return true;
    }
}

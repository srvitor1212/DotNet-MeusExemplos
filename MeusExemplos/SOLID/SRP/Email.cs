using SOLID.SRP.Interface;

namespace SOLID.SRP;

public class Email : IEmail
{
    public bool EnviarEmail()
    {
        Console.WriteLine("Enviou email");
        return true;
    }
}

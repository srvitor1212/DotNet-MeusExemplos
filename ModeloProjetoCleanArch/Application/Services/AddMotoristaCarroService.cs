using Application.Abstraction;
using Application.Payloads;

namespace Application.Services;

public class AddMotoristaCarroService : Comando<MotoristaCarroPayload>
{
    protected override Task ExecutarComand(MotoristaCarroPayload payload)
    {
        Console.WriteLine("EXECUTOU A SERVICE"); //todo: implmentar lógica
        throw new NotImplementedException();
    }
}

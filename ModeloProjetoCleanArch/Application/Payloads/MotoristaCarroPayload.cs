using Application.Abstraction;

namespace Application.Payloads;

public class MotoristaCarroPayload : IComandoPayload
{
    public Guid? MotoristaId { get; set; }
    public Guid? CarroId { get; set; }

    public bool IsValid() 
        => MotoristaId != null && CarroId != null;

}
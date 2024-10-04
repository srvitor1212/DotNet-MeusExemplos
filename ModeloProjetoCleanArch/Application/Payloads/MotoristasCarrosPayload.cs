using Application.Abstraction;
using Application.Payloads.Records;

namespace Application.Payloads;

public class MotoristasCarrosPayload : IComandoPayload
{
    public List<MotoristasCarrosRecord> Dados { get; set; } = new List<MotoristasCarrosRecord>();

    public bool IsValid()
        => Dados != null && Dados.Count > 0;

}
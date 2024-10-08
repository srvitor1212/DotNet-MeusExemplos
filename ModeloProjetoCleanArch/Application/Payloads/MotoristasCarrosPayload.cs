using Application.Abstraction;
using Application.Payloads.Records;

namespace Application.Payloads;

public class MotoristasCarrosPayload : IComandoPayload
{
    public List<MotoristasCarrosRecordPayload> Dados { get; set; } = new List<MotoristasCarrosRecordPayload>();

    public bool IsValid()
        => Dados != null && Dados.Count > 0;

}
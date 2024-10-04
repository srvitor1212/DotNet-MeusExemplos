using Application.Responses.Records;
using Domain.Model.MuitosPraMuitos;

namespace Application.Adapter;

public static class MotoristaAdapter
{
    public static MotoristasRecord ToMotoristas(this Motorista model)
        => new MotoristasRecord(
                    model.Id, 
                    model.Nome, 
                    $"{(int)model.SituacaoCarteiraMotorista} - {model.SituacaoCarteiraMotorista}",
                    $"{(int)model.TipoCarteira} - {model.TipoCarteira}");
}

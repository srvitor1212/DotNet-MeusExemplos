using Application.Responses.Records;
using Domain.Model.MuitosPraMuitos;

namespace Application.Adapter;

public static class MotoristaAdapter
{
    public static MotoristasRecordResponse ToMotoristas(this Motorista model)
        => new MotoristasRecordResponse(
                    model.Id, 
                    model.Nome, 
                    $"{(int)model.SituacaoCarteiraMotorista} - {model.SituacaoCarteiraMotorista}",
                    $"{(int)model.TipoCarteira} - {model.TipoCarteira}");
}

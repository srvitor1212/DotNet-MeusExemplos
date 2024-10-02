using Application.Responses;
using Domain.Model.MuitosPraMuitos;

namespace Application.Adapter;

public static class MotoristaAdapter
{
    public static Motoristas ToMotoristas(this Motorista model)
        => new Motoristas(
                    model.Id, 
                    model.Nome, 
                    $"{(int)model.SituacaoCarteiraMotorista} - {model.SituacaoCarteiraMotorista}",
                    $"{(int)model.TipoCarteira} - {model.TipoCarteira}");
}

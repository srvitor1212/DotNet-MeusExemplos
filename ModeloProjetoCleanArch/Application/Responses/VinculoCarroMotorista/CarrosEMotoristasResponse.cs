using Application.Responses.Records;
using Application.Responses.VinculoCarroMotorista;

namespace Application.Responses;

public class CarrosEMotoristasResponse : ICarroMotoristaResponse
{
    public string Modelo { get; set; } = string.Empty;

    public List<MotoristasRecordResponse> Motoristas { get; set; } = [];
}


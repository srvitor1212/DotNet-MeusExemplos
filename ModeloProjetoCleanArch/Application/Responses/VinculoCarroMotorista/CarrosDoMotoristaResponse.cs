using Application.Responses.VinculoCarroMotorista;

namespace Application.Responses;

public class CarrosDoMotoristaResponse : ICarroMotoristaResponse
{
    public Guid Carros { get; set; } = Guid.Empty;

    public List<Guid> Motoristas { get; set; } = [];
}

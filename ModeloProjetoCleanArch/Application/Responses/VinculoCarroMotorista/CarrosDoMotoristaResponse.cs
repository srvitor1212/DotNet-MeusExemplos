using Application.Responses.VinculoCarroMotorista;

namespace Application.Responses;

public class CarrosDoMotoristaResponse : ICarroMotoristaResponse
{
    public string Carros { get; set; } = string.Empty;

    public List<string> Motoristas { get; set; } = new List<string>();
}

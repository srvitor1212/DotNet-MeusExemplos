namespace Application.Responses.VinculoCarroMotorista;

public class MotoristasDoCarroResponse : ICarroMotoristaResponse
{
    public Guid Motorista { get; set; } = Guid.Empty;

    public List<Guid> Carros { get; set; } = [];
}

namespace Application.Responses.VinculoCarroMotorista;

public class MotoristasECarrosResponse : ICarroMotoristaResponse
{
    public Guid Motorista { get; set; } = Guid.Empty;

    public List<Guid> Carros { get; set; } = [];
}

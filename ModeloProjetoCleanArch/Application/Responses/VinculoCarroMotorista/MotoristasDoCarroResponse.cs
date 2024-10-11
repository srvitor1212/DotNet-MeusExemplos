namespace Application.Responses.VinculoCarroMotorista;

public class MotoristasDoCarroResponse : ICarroMotoristaResponse
{
    public string Motorista { get; set; } = string.Empty;

    public List<string> Carros { get; set; } = new List<string>();
}

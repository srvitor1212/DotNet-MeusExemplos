namespace Application.Responses;

public class CarrosDoMotoristaResponse
{
    public string Motorista { get; private set; } = string.Empty;

    public List<string> Carros { get; private set; } = [];

    public CarrosDoMotoristaResponse(string motorista, List<string> carro)
    {
        Motorista = motorista;
        Carros = carro;
    }
}

namespace Application.Responses;

public class CarroModeloResponse
{
    public string Modelo { get; private set; } = string.Empty;

    public CarroModeloResponse(string modelo)
    {
        Modelo = modelo;
    }
}

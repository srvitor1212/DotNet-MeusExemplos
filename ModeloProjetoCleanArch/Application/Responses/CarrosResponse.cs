namespace Application.Responses;

public class CarrosResponse
{
    public string Modelo { get; set; } = string.Empty;

    public CarrosResponse(string nome)
    {
        Modelo = nome;
    }
}

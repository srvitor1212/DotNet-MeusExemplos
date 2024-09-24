namespace Application.Responses;

public class CarrosResponse
{
    public string Nome { get; set; } = string.Empty;

    public CarrosResponse()
    {
    }

    public CarrosResponse(string nome)
    {
        Nome = nome;
    }
}

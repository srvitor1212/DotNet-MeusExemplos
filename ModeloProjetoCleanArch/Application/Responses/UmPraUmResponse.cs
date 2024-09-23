namespace Application.Responses;

public class UmPraUmResponse
{
    public string Nome { get; set; } = string.Empty;

    public UmPraUmResponse()
    {
    }

    public UmPraUmResponse(string nome)
    {
        Nome = nome;
    }
}

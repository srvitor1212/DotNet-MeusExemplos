namespace Application.Payloads;

public class CarrosPayload
{
    public DateTimeOffset dataCadastroInicial { get; private set; }
    public DateTimeOffset? dataCadastroFinal { get; private set; } = DateTimeOffset.MaxValue;

    public CarrosPayload(DateTimeOffset dataCadastroInicial, DateTimeOffset? dataCadastroFinal)
    {
        this.dataCadastroInicial = dataCadastroInicial;
        this.dataCadastroFinal = dataCadastroFinal ?? DateTimeOffset.MaxValue;
    }
}

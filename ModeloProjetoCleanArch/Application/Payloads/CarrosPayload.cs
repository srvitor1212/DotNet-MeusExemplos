namespace Application.Payloads;

public record CarrosPayload(
    DateTimeOffset dataCadastroInicial, 
    DateTimeOffset dataFinalInicial);

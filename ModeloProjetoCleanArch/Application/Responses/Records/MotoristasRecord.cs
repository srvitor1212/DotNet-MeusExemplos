namespace Application.Responses.Records;

public record MotoristasRecord(
    Guid Id,
    string Nome,
    string Situacao,
    string TipoHabilitacao);
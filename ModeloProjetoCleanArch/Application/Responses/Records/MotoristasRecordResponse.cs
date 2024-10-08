namespace Application.Responses.Records;

public record MotoristasRecordResponse(
    Guid Id,
    string Nome,
    string Situacao,
    string TipoHabilitacao);
using Domain.Enum;

namespace Application.Responses;

public class MotoristasECarrosResponse
{
    public IEnumerable<Carros> Carros { get; set; } = new List<Carros>();

    public IEnumerable<Motoristas> Motoristas { get; set; } = new List<Motoristas>();
}

public record Carros(
    Guid Id, 
    string Modelo);

public record Motoristas(
    Guid Id,
    string Nome,
    string Situacao,
    string TipoHabilitacao);
using Application.Responses.Records;

namespace Application.Responses;

public class MotoristasECarrosResponse
{
    public IEnumerable<CarrosRecord> Carros { get; set; } = new List<CarrosRecord>();

    public IEnumerable<MotoristasRecord> Motoristas { get; set; } = new List<MotoristasRecord>();
}

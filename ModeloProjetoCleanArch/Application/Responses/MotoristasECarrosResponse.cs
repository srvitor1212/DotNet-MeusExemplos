using Application.Responses.Records;

namespace Application.Responses;

public class MotoristasECarrosResponse
{
    public IEnumerable<CarrosRecordResponse> Carros { get; set; } = new List<CarrosRecordResponse>();

    public IEnumerable<MotoristasRecordResponse> Motoristas { get; set; } = new List<MotoristasRecordResponse>();
}

using Application.Abstraction;
using Application.Payloads;
using Application.Responses;

namespace Application.Services;

public class CarroComChassiService : IConsulta<CarrosPayload, IEnumerable<CarrosComChassiResponse>>
{
    public async Task<IEnumerable<CarrosComChassiResponse>> Consultar(CarrosPayload payload)
    {
        return await Task.FromResult(new List<CarrosComChassiResponse>());
    }
}

using Application.Abstraction;
using Application.Payloads;
using Application.Responses;

namespace Application.Services;

public class UmPraUmConsultaService : IConsulta<UmPraUmPayload, UmPraUmResponse>
{
    public async Task<UmPraUmResponse> Consultar(UmPraUmPayload payload)
    {
        return new UmPraUmResponse("Teste");
    }
}

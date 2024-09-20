using Application.Payloads;
using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI;

public static class Endpoints
{
    public static void AdicionarEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet("/carros",
            async ([AsParameters] UmPraUmPayload payload,
                   [FromServices] UmPraUmConsultaService service) =>
            {
                //todo: fazer um repository e consultar no banco de dados;
                return await service.Consultar(payload);
            }).WithTags("UmPraUm");
    }
}

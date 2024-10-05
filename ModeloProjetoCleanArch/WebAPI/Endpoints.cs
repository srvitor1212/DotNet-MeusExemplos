using Application.Payloads;
using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI;

public static class Endpoints
{
    public static void AdicionarEndpoints(this IEndpointRouteBuilder app)
    {

        #region Um pra Um

        app.MapGet("/carros",
            async ([AsParameters] CarrosPayload payload,
                   [FromServices] CarrosPorDataService service) =>
            {
                return await service.Consultar(payload);
            }).WithTags("UmPraUm");


        app.MapGet("carros-com-chassi",
            async ([AsParameters] CarrosPayload payload,
                   [FromServices] CarroComChassiService service) =>
            {
                return await service.Consultar(payload);
            }).WithTags("UmPraUm");

        #endregion





        #region Um pra Muitos

        app.MapGet("carros-por-fabricante",
            async ([AsParameters] FabricantePayload payload,
                   [FromServices] CarrosPorFabricante service) =>
            {
                return await service.Consultar(payload);
            }).WithTags("UmPraMuitos");

        #endregion





        #region Muitos pra Muitos

        app.MapGet("listar-motoristas-e-carros",
            async ([FromServices] ListarMotoristasECarrosService service) =>
            {
                return await service.Consultar();
            }).WithTags("MuitosPraMuitos");


        app.MapPost("associar-motorista-ao-carro",
            async ([FromBody] MotoristasCarrosPayload payload,
            [FromServices] AddMotoristaCarroService service) =>
            {
                var result = await service.Processar(payload);

                if (!result.Success)
                    return Results.BadRequest(result.Message);

                return Results.Created();

            }).WithTags("MuitosPraMuitos");

        #endregion
    }
}

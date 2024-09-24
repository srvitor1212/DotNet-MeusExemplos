﻿using Application.Payloads;
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
    }
}

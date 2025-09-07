
using LogApiTasks;
using Microsoft.AspNetCore.Mvc;
using MultiTasksApi.database;

namespace MultiTasksApi;

public static class Endpoints
{
    public static void AdicionarEndpoint(this IEndpointRouteBuilder app)
    {
        app.MapGet("/SyncRequest_CpuBound",
        (long loops = 500_000_000) =>
        {
            var id = Guid.NewGuid();
            Log.Write(id, "SyncRequest_CpuBound inicio");
            CpuBound(loops);
            Log.Write(id, "SyncRequest_CpuBound fim", end: true);
        })
        .WithOpenApi();


        app.MapGet("/AsyncRequest_CpuBoundAsync",
        async (long loops = 500_000_000) =>
        {
            var id = Guid.NewGuid();
            Log.Write(id, "AsyncRequest_CpuBoundAsync inicio");
            await CpuBoundAsync(loops);
            Log.Write(id, "AsyncRequest_CpuBoundAsync fim", end: true);
        })
        .WithOpenApi();


        app.MapGet("/FalsoAsyncRequest",
        async (long loops = 500_000_000) =>
        {
            var id = Guid.NewGuid();
            Log.Write(id, "CpuBoundFalsoAsync inicio");
            await CpuBoundFalsoAsync(loops);
            Log.Write(id, "CpuBoundFalsoAsync fim", end: true);
        })
        .WithOpenApi();


        app.MapGet("/FalsoAsyncRequestConsultaNoBanco",
        async (
            [FromServices] ClienteService service) =>
        {
            var id = Guid.NewGuid();
            Log.Write(id, "FalsoAsyncRequestConsultaNoBanco inicio");
            var result = await service.GetAll();
            Log.Write(id, "FalsoAsyncRequestConsultaNoBanco fim", end: false);
            return result;
        })
        .WithOpenApi();

    }

    private static void CpuBound(long loops)
    {
        var id = Guid.NewGuid();
        Log.Write(id, "CpuBound inicio");
        var rand = new Random();
        for (long i = 0; i < loops; i++)
            rand.Next();
        Log.Write(id, "CpuBound fim");
    }

    private static Task CpuBoundAsync(long loops)
    {
        return Task.Run(() =>
        {
            var id = Guid.NewGuid();
            Log.Write(id, "CpuBoundAsync inicio");
            var rand = new Random();
            for (long i = 0; i < loops; i++)
                rand.Next();
            Log.Write(id, "CpuBoundAsync fim");
        });
    }

    private async static Task CpuBoundFalsoAsync(long loops)
    {
        var id = Guid.NewGuid();
        Log.Write(id, "CpuBoundFalsoAsync inicio");
        var rand = new Random();
        for (long i = 0; i < loops; i++)
            rand.Next();
        Log.Write(id, "CpuBoundFalsoAsync fim");
    }

}

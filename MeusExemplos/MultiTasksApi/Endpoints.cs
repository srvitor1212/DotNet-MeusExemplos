
using LogApiTasks;

namespace MultiTasksApi;

public static class Endpoints
{
    public static void AdicionarEndpoint(this IEndpointRouteBuilder app)
    {
        app.MapGet("/SyncRequest",
        (long loops = 500_000_000) =>
        {
            var id = Guid.NewGuid();
            Log.Write(id, "SyncRequest inicio");
            CpuBound(loops);
            Log.Write(id, "SyncRequest fim", end: true);
        })
        .WithOpenApi();


        app.MapGet("/AsyncRequest",
        async (long loops = 500_000_000) =>
        {
            var id = Guid.NewGuid();
            Log.Write(id, "AsyncRequest inicio");
            await CpuBoundAsync(loops);
            Log.Write(id, "AsyncRequest fim", end: true);
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

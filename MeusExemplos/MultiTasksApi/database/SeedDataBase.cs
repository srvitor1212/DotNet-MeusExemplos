using LogApiTasks;

namespace MultiTasksApi.database;

public class SeedDataBase(IClienteRepo clienteRepo)
{
    public IClienteRepo _repo = clienteRepo;

    private const int total_registros = 300_000;

    public async Task SeedCliente()
    {
        var id = Guid.NewGuid();
        Log.Write(id, "SeedCliente inicio");

        var result = await _repo.GetAllAsync();

        var clientes = new List<Cliente>();

        if (!result.Any())
        {
            Log.Write(id, "SeedCliente inserts...");

            for (long i = 1; i <= total_registros; i++)
                clientes.Add(new() { Nome = $"Cliente {i}" });

            await _repo.InsertRange(clientes);
        }

        Log.Write(id, "SeedCliente fim");
    }
}

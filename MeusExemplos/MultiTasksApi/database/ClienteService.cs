using LogApiTasks;

namespace MultiTasksApi.database;

public class ClienteService
{

    private readonly IClienteRepo _clienteRepo;

    public ClienteService(IClienteRepo clienteRepo)
    {
        _clienteRepo = clienteRepo;
    }

    public async Task<IEnumerable<Cliente>> GetAll()
    {
        var id = Guid.NewGuid();
        Log.Write(id, "ClienteService inicio");
        var result = await _clienteRepo.GetAllAsync();
        Log.Write(id, "ClienteService fim");

        return result;
    }
        
}

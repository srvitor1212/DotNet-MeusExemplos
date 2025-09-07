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
        return await _clienteRepo.GetAllAsync();
    }
        
}

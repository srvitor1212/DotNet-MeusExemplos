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
        await Task.Delay(15 * 1000);
        return await _clienteRepo.GetAllAsync();
    }
        
}

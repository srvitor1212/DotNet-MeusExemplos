namespace MultiTasksApi.database;

public interface IClienteRepo
{
    Task<IEnumerable<Cliente>> GetAllAsync();
}

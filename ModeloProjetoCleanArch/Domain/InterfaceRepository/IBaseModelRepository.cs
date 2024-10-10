using Domain.Model;

namespace Domain.InterfaceRepository;

public interface IBaseModelRepository<T> : IBasePrincipalRepository<T> where T : BaseModel
{
    Task<T?> GetSingleById(Guid id);
}

using Domain.Model.Base;

namespace Domain.InterfaceRepository.Base;

public interface IBaseModelRepository<T> : ICoreRepository<T> where T : BaseModel
{
}

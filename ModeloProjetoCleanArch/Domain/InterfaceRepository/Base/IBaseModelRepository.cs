using Domain.Model.Base;
using System.Linq.Expressions;

namespace Domain.InterfaceRepository.Base;

public interface IBaseModelRepository<T> : ICoreRepository<T> where T : BaseModel
{
}

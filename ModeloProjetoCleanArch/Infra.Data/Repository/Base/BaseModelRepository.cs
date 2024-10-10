using Domain.InterfaceRepository.Base;
using Domain.Model.Base;
using Infra.Data.Context;

namespace Infra.Data.Repository.Base;

public abstract class BaseModelRepository<T> : 
                        CoreRepository<T>,
                        IBaseModelRepository<T> where T : BaseModel
{

    public BaseModelRepository(MeuContext context) : base(context) { }


    public Task<T?> GetSingleById(Guid id)
        => Task.FromResult(_dbSet.Find(id));

}

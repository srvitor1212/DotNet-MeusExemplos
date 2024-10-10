namespace Domain.Model;

public abstract class BaseModel : BasePrincipal
{
    public Guid Id { get; protected set; } = Guid.NewGuid();

    protected BaseModel()
    {
    }

    protected BaseModel(Guid id)
    {
        Id = id;
    }
}

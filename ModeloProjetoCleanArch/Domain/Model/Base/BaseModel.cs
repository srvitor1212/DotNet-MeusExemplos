namespace Domain.Model.Base;

public abstract class BaseModel : Core
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

namespace Domain;

public abstract class BaseModel
{
    public Guid Id { get; protected set; } = Guid.NewGuid();
    public DateTimeOffset DataCriacao { get; protected set; } = DateTimeOffset.Now;
    public DateTimeOffset? DataAtualizacao { get; protected set; }

    protected BaseModel()
    {
    }

    protected BaseModel(Guid id)
    {
        Id = id;
    }

    public void SetDataAtualizacao() => DataAtualizacao = DateTimeOffset.Now;
    public void SetDataAtualizacao(DateTimeOffset date) => date = DateTimeOffset.Now;
}

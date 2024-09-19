namespace Domain;

public abstract class BaseModel
{
    public Guid Id { get; protected set; } = Guid.NewGuid();
    public DateTimeOffset DataCriacao { get; protected set; }
    public DateTimeOffset? DataAtualizacao { get; protected set; }

    protected BaseModel()
    {
        SetDataCriacao();
    }

    protected BaseModel(Guid id)
    {
        Id = id;
        SetDataCriacao();
    }

    public void SetDataAtualizacao() => DataAtualizacao = DateTimeOffset.Now;
    public void SetDataAtualizacao(DateTimeOffset date) => date = DateTimeOffset.Now;

    internal void SetDataCriacao() => DataCriacao = DateTimeOffset.Now;
}

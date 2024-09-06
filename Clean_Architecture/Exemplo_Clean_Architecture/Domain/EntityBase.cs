namespace Domain;

public abstract class EntityBase
{
    public Guid Id { get; protected set; }

    public DateTimeOffset DataCriacao { get; protected set; }

    public DateTimeOffset DataAtualizacao { get; protected set; }




    protected EntityBase()
    {
        Id = Guid.NewGuid();
        SetDataCriacao();
    }

    protected EntityBase(Guid id)
    {
        Id = id;
        SetDataCriacao();
    }



    public void SetDataAtualizacao() => DataAtualizacao = DateTimeOffset.Now;
    private void SetDataCriacao() => DataCriacao = DateTimeOffset.Now;
}

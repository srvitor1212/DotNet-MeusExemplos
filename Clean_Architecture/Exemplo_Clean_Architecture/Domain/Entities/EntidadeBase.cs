namespace Domain.Entities;

public class EntidadeBase
{
    public Guid Id { get; protected set; }

    public DateTimeOffset DataCriacao { get; protected set; }

    public DateTimeOffset DataAtualizacao { get; protected set; }




    protected EntidadeBase()
    {
        Id = Guid.NewGuid();
        SetDataCriacao();
    }

    protected EntidadeBase(Guid id)
    {
        Id = id;
        SetDataCriacao();
    }



    public void SetDataAtualizacao() => DataAtualizacao = DateTimeOffset.Now;
    private void SetDataCriacao() => DataCriacao = DateTimeOffset.Now;
}

namespace Domain.Model.Base;

public abstract class Core
{
    public DateTimeOffset DataCriacao { get; private set; } = DateTimeOffset.Now;
    public DateTimeOffset? DataAtualizacao { get; private set; }

    public void SetDataAtualizacao() => DataAtualizacao = DateTimeOffset.Now;
    public void SetDataAtualizacao(DateTimeOffset date) => DataAtualizacao = date;
}

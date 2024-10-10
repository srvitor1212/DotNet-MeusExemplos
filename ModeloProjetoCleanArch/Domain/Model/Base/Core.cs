namespace Domain.Model.Base;

public abstract class Core
{
    public DateTimeOffset DataCriacao { get; set; } = DateTimeOffset.Now;
    public DateTimeOffset? DataAtualizacao { get; set; }

    public void SetDataAtualizacao() => DataAtualizacao = DateTimeOffset.Now;
    public void SetDataAtualizacao(DateTimeOffset date) => date = DateTimeOffset.Now;
}

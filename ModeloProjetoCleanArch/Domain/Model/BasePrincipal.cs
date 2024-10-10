namespace Domain.Model;

public abstract class BasePrincipal
{
    public DateTimeOffset DataCriacao { get; set; } = DateTimeOffset.Now;
    public DateTimeOffset? DataAtualizacao { get; set; }

    public void SetDataAtualizacao() => DataAtualizacao = DateTimeOffset.Now;
    public void SetDataAtualizacao(DateTimeOffset date) => date = DateTimeOffset.Now;
}

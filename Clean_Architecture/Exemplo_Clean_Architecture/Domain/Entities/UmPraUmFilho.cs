namespace Domain.Entities;

public class UmPraUmFilho : EntidadeBase
{
    public string Nome { get; set; }

    public string Categoria { get; set; }

    public Guid UmPraUmPaiId { get; set; }




    public UmPraUmPai UmPraUmPai { get; set; } = null!;
}

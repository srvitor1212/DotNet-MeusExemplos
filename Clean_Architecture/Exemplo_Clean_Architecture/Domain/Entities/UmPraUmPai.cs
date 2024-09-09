namespace Domain.Entities;

public class UmPraUmPai : EntidadeBase
{
    public string Nome { get; set; }

    public decimal Valor { get; set; }



    public UmPraUmFilho? UmPraUmFilho { get; set; }
}

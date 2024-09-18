namespace Domain.Model.UmPraUm;

public class Carro : BaseModel
{
    public string Modelo { get; private set; } = string.Empty;
    public Guid CategoriaId { get; private set; }

    public Categoria Categoria { get; private set; } = null!;
}

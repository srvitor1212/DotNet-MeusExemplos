namespace Domain.Model.UmPraUm;

public class Categoria : BaseModel
{
    public string Nome { get; set; } = string.Empty;


    public Categoria(string nome)
    {
        Nome = nome;
    }
}

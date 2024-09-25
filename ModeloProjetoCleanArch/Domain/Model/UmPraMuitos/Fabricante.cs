using Domain.Model.UmPraUm;

namespace Domain.Model.UmPraMuitos;

public class Fabricante : BaseModel
{
    public string Nome { get; set; } = string.Empty;
    public string CNPJ { get; set; } = string.Empty;

    // Propriedade de navegação
    public ICollection<Carro> Carros { get; set; } = new List<Carro>();
}

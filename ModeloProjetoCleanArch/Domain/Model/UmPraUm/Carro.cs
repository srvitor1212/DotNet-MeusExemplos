using Domain.Model.UmPraMuitos;

namespace Domain.Model.UmPraUm;

public class Carro : BaseModel
{
    public string Modelo { get; set; } = string.Empty;


    // Propriedade de navegação
    public Chassi Chassi { get;  set; } = null!;


    // 1:N - UM carro MUITOS fabricante
    public Guid FabricanteId { get; set; }
    public Fabricante Fabricante { get; set; } = null!;
}

using Domain.Model.Base;
using Domain.Model.MuitosPraMuitos;
using Domain.Model.UmPraMuitos;

namespace Domain.Model.UmPraUm;

public class Carro : BaseModel
{
    public string Modelo { get; set; } = string.Empty;

    // Propriedade de navegação
    public Chassi Chassi { get;  set; } = null!;
    public ICollection<CarroMotorista> CarroMotorista { get; set; } = new List<CarroMotorista>();


    // 1:N - UM carro MUITOS fabricante
    public Guid FabricanteId { get; set; }
    public Fabricante Fabricante { get; set; } = null!;


    // Construtor
    public Carro() { }

    public Carro(Guid Id) : base(Id) { }
}

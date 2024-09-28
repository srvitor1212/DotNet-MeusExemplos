using Domain.Enum;

namespace Domain.Model.MuitosPraMuitos;

public class Motorista : BaseModel
{
    public string Nome { get; set; } = string.Empty;
    public SituacaoCarteiraMotorista SituacaoCarteiraMotorista { get; set; }
    public TipoCarteira TipoCarteira { get; set; }

    // Propriedade de navegação
    public ICollection<CarroMotorista> CarroMotorista { get; set; } = new List<CarroMotorista>();

}

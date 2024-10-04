using Domain.Model.UmPraUm;

namespace Domain.Model.MuitosPraMuitos;

public class CarroMotorista : BaseModel
{
    public Guid CarroId { get; set; }
    public Carro Carro { get; set; } = null!;

    public Guid MotoristaId { get; set; }
    public Motorista Motorista { get; set; } = null!;

    public CarroMotorista(Guid carroId, Guid motoristaId)
    {
        CarroId = carroId;
        MotoristaId = motoristaId;
    }
}

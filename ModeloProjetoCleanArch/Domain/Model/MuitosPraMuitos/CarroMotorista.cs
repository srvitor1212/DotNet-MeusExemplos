using Domain.Model.Base;
using Domain.Model.UmPraUm;

namespace Domain.Model.MuitosPraMuitos;


/* Nesse caso não herda de BaseModel pois não queremos uma coluna Id.
 * Caso tenha uma coluna Id o entity automáticamente coloca ela como PK.
 * E nesse caso queremos uma chave composta de {CarroId, MotoristaId} */
public class CarroMotorista : Core
{

    //todo criar uma classe vase com updatedAt e CreatedAt para herdar aqui

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

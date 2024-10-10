using Domain.Model.Base;
using Domain.Model.UmPraUm;

namespace Domain.Model.MuitosPraMuitos;


/* Nesse caso não herda de BaseModel pois não queremos uma coluna Id.
 * Caso tenha uma coluna Id o entity automáticamente coloca ela como PK.
 * E nesse caso queremos uma chave composta de {CarroId, MotoristaId} */
public class CarroMotorista : Core
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

//todo: como ficaria outra tabela se relacionace com essa daqui que é chave composta ?

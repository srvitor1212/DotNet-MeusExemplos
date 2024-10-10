using Domain.Model.Base;

namespace Domain.Model.UmPraUm;

public class Chassi : BaseModel
{
    public uint NumeroDeSerie { get; set; }     // uint = 0 a 4.294.967.295	Inteiro de 32 bits sem sinal
    
    
    // 1:1 relacionamento
    public Guid CarroId { get; set; }
    public Carro Carro { get; set; } = null!;
}

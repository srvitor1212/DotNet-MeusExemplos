namespace Domain.Model.UmPraUm;

public class Chassi : BaseModel
{
    public uint NumeroDeSerie { get; private set; }     // uint = 0 a 4.294.967.295	Inteiro de 32 bits sem sinal
    
    
    // 1:1 relacionamento
    public Guid CarroId { get; private set; }
    public Carro Carro { get; private set; } = null!;


    public Chassi(uint numeroDeSerie)
    {
        NumeroDeSerie = numeroDeSerie;
    }
}

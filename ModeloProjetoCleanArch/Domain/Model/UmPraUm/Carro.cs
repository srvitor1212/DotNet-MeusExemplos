namespace Domain.Model.UmPraUm;

public class Carro : BaseModel
{
    public string Modelo { get; private set; } = string.Empty;


    // Propriedade de navegação
    public Chassi Chassi { get; private set; } = null!;

    public Carro(string modelo)
    {
        Modelo = modelo;
    }
}

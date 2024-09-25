namespace Application.Responses;

public class CarroChassiResponse
{
    public string Modelo { get; set; } = string.Empty;
    public uint NrChassi { get; set; }

    public CarroChassiResponse(string modelo, uint nrChassi)
    {
        Modelo = modelo;
        NrChassi = nrChassi;
    }
}

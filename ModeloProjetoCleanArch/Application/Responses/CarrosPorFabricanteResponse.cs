namespace Application.Responses;

public class CarrosPorFabricanteResponse
{
    public Guid FabricanteId { get; private set; }
    public string Fabricante { get; private set; } = string.Empty;
    public ICollection<CarroModeloResponse> Veiculos { get; set; }

    public CarrosPorFabricanteResponse(Guid fabricanteId, string fabricante, ICollection<CarroModeloResponse> veiculos)
    {
        FabricanteId = fabricanteId;
        Fabricante = fabricante;
        Veiculos = veiculos;
    }
}

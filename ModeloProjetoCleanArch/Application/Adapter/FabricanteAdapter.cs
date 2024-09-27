using Application.Responses;
using Domain.Model.UmPraMuitos;

namespace Application.Adapter;

public static class FabricanteAdapter
{
    public static CarrosPorFabricanteResponse ToResponse(this Fabricante fabricante) 
        => new CarrosPorFabricanteResponse(
                    fabricante.Id,
                    fabricante.Nome,
                    fabricante.Carros.Select(x => new CarroModeloResponse(x.Modelo)).ToList());
}

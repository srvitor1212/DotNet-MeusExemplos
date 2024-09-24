using Application.Responses;
using Domain.Model.UmPraUm;

namespace Application.Adapter;

public static class CarroAdapter
{
    public static UmPraUmResponse ToResponse(this Carro model)
        => new UmPraUmResponse(model.Modelo);
}

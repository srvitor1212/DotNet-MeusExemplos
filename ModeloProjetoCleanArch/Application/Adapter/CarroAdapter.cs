using Application.Responses;
using Domain.Model.UmPraUm;

namespace Application.Adapter;

public static class CarroAdapter
{
    public static CarrosResponse ToResponse(this Carro model)
        => new CarrosResponse(model.Modelo);
}

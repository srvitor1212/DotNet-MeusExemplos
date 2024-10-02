using Application.Responses;
using Domain.Model.UmPraUm;

namespace Application.Adapter;

public static class CarroAdapter
{
    public static CarrosResponse ToResponse(this Carro model)
        => new CarrosResponse(model.Modelo);

    public static CarroChassiResponse ToResponseCarroChassi(this Carro model)
        => new CarroChassiResponse(model.Modelo, model.Chassi.NumeroDeSerie);

    public static Carros ToCarros(this Carro model)
        => new Carros(model.Id, model.Modelo);
}

﻿using Application.Responses;
using Application.Responses.Records;
using Domain.Model.UmPraUm;

namespace Application.Adapter;

public static class CarroAdapter
{
    public static CarrosResponse ToResponse(this Carro model)
        => new CarrosResponse(model.Modelo);

    public static CarroChassiResponse ToResponseCarroChassi(this Carro model)
        => new CarroChassiResponse(model.Modelo, model.Chassi.NumeroDeSerie);

    public static CarrosRecordResponse ToCarros(this Carro model)
        => new CarrosRecordResponse(model.Id, model.Modelo);
}

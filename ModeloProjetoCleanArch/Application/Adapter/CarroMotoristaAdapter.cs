using Application.Responses;
using Domain.Model.MuitosPraMuitos;

namespace Application.Adapter;

public static class CarroMotoristaAdapter
{
    public static IEnumerable<CarrosDoMotoristaResponse> ToCarrosDoMotoristaResponse(IEnumerable<CarroMotorista> model)
    {
        var result = new List<CarrosDoMotoristaResponse>();

        var modelPorMotorista = model.GroupBy(x => x.MotoristaId);

        foreach (var motorista in modelPorMotorista)
        {
            var carros = GetCarros(motorista);

            result.Add(new CarrosDoMotoristaResponse(motorista.FirstOrDefault()!.Motorista.Nome, carros));
        }

        return result;
    }

    private static List<string> GetCarros(IGrouping<Guid, CarroMotorista> motoristas)
    {
        var result = new List<string>();

        foreach (var carro in motoristas) 
        {
            result.Add(carro.Carro.Modelo);
        }

        return result;
    }

}

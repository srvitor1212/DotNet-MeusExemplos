using Application.Abstraction;
using Application.Responses.Records;
using Domain.InterfaceRepository;

namespace Application.Services;

public class RandomMotoristaCarroService : IConsulta<IEnumerable<MotoristasCarrosRecordResponse>>
{

    private readonly IMotoristaRepository _motoristaRepository;
    private readonly ICarroRepository _carroRepository;

    public RandomMotoristaCarroService(IMotoristaRepository motoristaRepository, ICarroRepository carroRepository)
    {
        _motoristaRepository = motoristaRepository;
        _carroRepository = carroRepository;
    }

    public async Task<IEnumerable<MotoristasCarrosRecordResponse>> Consultar()
    {
        var motoristas = (await _motoristaRepository.GetQueryable()).ToList();

        var carros = (await _carroRepository.GetQueryable()).ToList();

        var result = new List<MotoristasCarrosRecordResponse>();

        var rand = new Random();

        for (var i = 0; i < 100; i++)
        {
            Console.Write(rand.Next(0, motoristas.Count));
            var motorista = motoristas[rand.Next(0, motoristas.Count)];

            var carro = carros[rand.Next(0, carros.Count)];

            result.Add(new MotoristasCarrosRecordResponse(motorista.Id, carro.Id));
        }

        return result;

    }
}

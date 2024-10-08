using Application.Abstraction;
using Application.Message;
using Application.Payloads;
using Domain.InterfaceRepository;
using Domain.Model.MuitosPraMuitos;
using Domain.Model.UmPraUm;

namespace Application.Services;

public class AddMotoristaCarroService : Comando<MotoristasCarrosPayload>
{

    private readonly ICarroMotoristaRepository _repository;
    private readonly ICarroRepository _carroRepository;
    private readonly IMotoristaRepository _motoristaRepository;

    public AddMotoristaCarroService(ICarroMotoristaRepository carroMotoristaRepository,
                                    IMotoristaRepository motoristaRepository,
                                    ICarroRepository carroRepository)
    {
        _repository = carroMotoristaRepository;
        _motoristaRepository = motoristaRepository;
        _carroRepository = carroRepository;
    }

    protected override async Task<ServiceResult> ExecutarComand(MotoristasCarrosPayload payload)
    {
        var errors = await AdicionarVinculos(payload);

        if (errors.Count == 0)
            return ServiceResult.Ok();

        return ServiceResult.Invalid($"Erro ao criar vinculos: {string.Join(", ", errors)}");
    }

    private async Task<List<string>> AdicionarVinculos(MotoristasCarrosPayload payload)
    {
        var errors = new List<string>();

        var dadosOrdenadosPorCarro = payload.Dados.Distinct()
                                                  .OrderBy(x => x.CarroId)
                                                  .ToList();

        Carro? carro = new Carro(Guid.Empty);

        foreach(var item in dadosOrdenadosPorCarro) //todo testar
        {
            if (carro != null && item.CarroId == carro!.Id)
                continue; //todo ta pulando mas tem que adicionar o motorista 
                
            carro = await _carroRepository.GetSingleById(item.CarroId);

            if (carro == null)
            {
                errors.Add($"CarroId {item.CarroId} não encontrado");
                continue;
            }

            var motorista = await _motoristaRepository.GetSingleById(item.MotoristaId);

            if (motorista == null)
            {
                errors.Add($"MotoristaId {item.MotoristaId} não encontrado");
                continue;
            }

            await _repository.Create(new CarroMotorista(item.CarroId, item.MotoristaId));
        }

        return errors;
    }
}

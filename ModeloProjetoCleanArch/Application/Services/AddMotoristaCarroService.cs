using Application.Abstraction;
using Application.Message;
using Application.Payloads;
using Domain.InterfaceRepository;
using Domain.Model.MuitosPraMuitos;

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

        foreach (var item in payload.Dados)
        {
            var carro = await _carroRepository.GetSingleById(item.CarroId);

            if (carro == null)
                errors.Add($"CarroId não encontrado {item.CarroId}");


            var motorista = await _motoristaRepository.GetSingleById(item.MotoristaId);

            if (motorista == null)
                errors.Add($"MotoristaId não encontrado {item.MotoristaId}");


            if (carro != null && motorista != null)
                await _repository.Create(new CarroMotorista(item.CarroId, item.MotoristaId));
        }

        return errors;

    }
}

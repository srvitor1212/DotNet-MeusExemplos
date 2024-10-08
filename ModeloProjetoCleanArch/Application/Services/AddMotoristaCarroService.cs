using Application.Abstraction;
using Application.Message;
using Application.Payloads;
using Application.Payloads.Records;
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

        var dadosOrdenadosPorCarro = payload.Dados.Distinct()
                                                  .OrderBy(x => x.CarroId)
                                                  .GroupBy(x => x.CarroId)
                                                  .ToList();

        foreach (var itemCarro in dadosOrdenadosPorCarro)
        {
            var carro = await _carroRepository.GetSingleById(itemCarro.Key);

            if (carro == null)
            {
                errors.Add($"O id {itemCarro.Key} para carro não foi encontrado!");
                continue;
            }

            await VincularCarroAosMotoristas(itemCarro, errors);
        }

        return errors;
    }

    private async Task VincularCarroAosMotoristas(IGrouping<Guid, MotoristasCarrosRecordPayload> itemCarro, List<string> errors)
    {
        foreach (var itemMotorista in itemCarro)
        {
            var motorista = await _motoristaRepository.GetSingleById(itemMotorista.MotoristaId);

            if (motorista == null)
            {
                errors.Add($"O id {itemMotorista.MotoristaId} para motorista não foi encontrado!");
                continue;
            }

            await _repository.Create(
                new CarroMotorista(itemCarro.Key, itemMotorista.MotoristaId)); //todo: validar se o vinculo já existe;
        }
    }
}

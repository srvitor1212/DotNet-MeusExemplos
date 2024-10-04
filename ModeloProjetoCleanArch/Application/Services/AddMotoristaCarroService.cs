using Application.Abstraction;
using Application.Payloads;
using Domain.InterfaceRepository;
using Domain.Model.MuitosPraMuitos;

namespace Application.Services;

public class AddMotoristaCarroService : Comando<MotoristasCarrosPayload>
{

    private readonly ICarroMotoristaRepository _carroMotoristaRepository;
    private readonly IMotoristaRepository _motoristaRepository;

    public AddMotoristaCarroService(ICarroMotoristaRepository carroMotoristaRepository,
                                    IMotoristaRepository motoristaRepository)
    {
        _carroMotoristaRepository = carroMotoristaRepository;
        _motoristaRepository = motoristaRepository;
    }

    protected override async Task ExecutarComand(MotoristasCarrosPayload payload)
    {

        //todo: retornar algum erro quando não existe motorista ou carro
        foreach (var item in payload.Dados) {

            var carro = await _carroMotoristaRepository.GetSingleById(item.CarroId);

            if (carro == null)
                throw new InvalidDataException("CarroId inválido!");

            var motorista = _motoristaRepository.GetSingleById(item.MotoristaId);

            if (motorista == null)
                throw new InvalidDataException("MotoristaId inválido");

            await _carroMotoristaRepository.Create(new CarroMotorista(item.CarroId, item.MotoristaId));
        }        
    }
}

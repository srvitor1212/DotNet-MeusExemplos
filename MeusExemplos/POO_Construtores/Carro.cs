namespace POO_Construtores;

public class Carro(IRepositoryInterface repository) //Construtor primário, funciona a partir do .NET8
{
    private readonly IRepositoryInterface _repository = repository;

    public bool CarTypeBrazilian()
    {
        return _repository.BrazilianCar();
    }
}

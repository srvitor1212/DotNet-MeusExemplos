namespace Application.Abstraction;

public interface IConsulta<TPayload, TResponse>
{
    Task<TResponse> Consultar(TPayload payload);
}

public interface IConsulta<TResponse>
{
    Task<TResponse> Consultar();
}

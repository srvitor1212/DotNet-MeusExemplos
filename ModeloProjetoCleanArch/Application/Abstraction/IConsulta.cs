namespace Application.Abstraction;

public interface IConsulta<TPayload, TResponse>
{
    Task<TResponse> Consultar(TPayload payload);
}

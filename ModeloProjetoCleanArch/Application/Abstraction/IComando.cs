namespace Application.Abstraction;

public interface IComando<TPayload>
{
    Task Processar(TPayload payload);
}

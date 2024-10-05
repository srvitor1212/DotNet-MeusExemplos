using Application.Message;

namespace Application.Abstraction;

public interface IComando<TPayload>
{
    Task<ServiceResult> Processar(TPayload payload);
}

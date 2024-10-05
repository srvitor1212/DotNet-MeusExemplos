using Application.Message;

namespace Application.Abstraction;

public abstract class Comando<T> : IComando<T> where T : IComandoPayload
{
    public async Task<ServiceResult> Processar(T payload)
    {
        if (!payload.IsValid())
            return ServiceResult.Invalid("Payload não é válido");

        try
        {
            var result = await ExecutarComand(payload);

            return result;
        }
        catch (Exception ex)
        {
            return ServiceResult.Invalid($"Erro ao executar comando, exp: {ex}");
        }
    }

    protected abstract Task<ServiceResult> ExecutarComand(T payload);
}

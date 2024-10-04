namespace Application.Abstraction;

public abstract class Comando<T> : IComando<T> where T : IComandoPayload
{
    public Task Processar(T payload)
    {
        if (!payload.IsValid())
            throw new InvalidDataException("Payload não é válido!");

        try
        {
            var result = ExecutarComand(payload);
            return Task.FromResult(result);
        }
        catch (Exception ex)
        {
            throw new Exception($"Erro ao executar comando, exp: {ex}");
        }
    }

    protected abstract Task ExecutarComand(T payload);
}

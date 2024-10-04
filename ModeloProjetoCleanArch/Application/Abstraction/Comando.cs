namespace Application.Abstraction;

public abstract class Comando<TPayload> : IComando<TPayload> where TPayload : IComandoPayload
{
    public Task Processar(TPayload payload)
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

    protected abstract Task ExecutarComand(TPayload payload);
}

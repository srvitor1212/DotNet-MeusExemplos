namespace CalculoHoras.App.Processamento;

public static class BuscarArquivos
{
    public static List<string> GetArquivosParaImportar()
    {
        return new List<string>()
        {
            "Registro de atendimento(Funcionário-1).txt",
            "Registro de atendimento(Funcionário-2).txt",
            "Registro de atendimento(Funcionário-3).txt",
            "Registro de atendimento(Funcionário-4).txt",
        };
    }
}

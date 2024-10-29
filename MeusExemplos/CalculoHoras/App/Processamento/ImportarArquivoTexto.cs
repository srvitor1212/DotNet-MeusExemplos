namespace CalculoHoras.App.Processamento;

public class ImportarArquivoTexto : Importar
{

    public string ArquivoCsv { get; private set; } = string.Empty;
    public string LayoutCabecalho { get; private set; } = string.Empty;

    public ImportarArquivoTexto(
        string path, string arquivo, string layoutCabecalho)
        : base(path, arquivo)
    {
        LayoutCabecalho = layoutCabecalho;
    }


    public string ImportarArquivo()
    {
        if (!FileIsOk())
            throw new FileLoadException("Erro ao processar arquivo!");


        throw new NotImplementedException();
    }

    private bool FileIsOk()
    {
        if (!File.Exists(FullPath))
        {
            Console.WriteLine("ERRO : Arquivo não encontrado");
            return false;
        }

        var linhas = File.ReadAllLines(FullPath);

        if (linhas.Length == 0)
        {
            Console.WriteLine("ERRO : Arquivo vazio");
            return false;
        }

        if (linhas.FirstOrDefault() != LayoutCabecalho)
        {
            Console.WriteLine("ERRO : Cabeçalho do arquivo inválido");
            return false;
        }

        return true;
    }
}

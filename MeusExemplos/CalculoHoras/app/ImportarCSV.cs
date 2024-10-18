using CsvHelper.Configuration;
using CsvHelper;
using System.Globalization;

namespace CalculoHoras.app;

public class ImportarCSV
{
    public string Path { get; private set; } = string.Empty;
    public string Arquivo { get; private set; } = string.Empty;
    public string FullPath { get; private set; }

    public ImportarCSV(string path, string arquivo)
    {
        Path = path;
        Arquivo = arquivo;
        FullPath = $"{Path}\\{Arquivo}";
    }

    public List<Marcacao> GetMarcacoes()
    {

        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            Delimiter = ";",
            HasHeaderRecord = true
        };

        var batidas = new List<Marcacao>();

        using (var reader = new StreamReader(FullPath))
        using (var csv = new CsvReader(reader, config))
        {
            var linhas = new List<LinhaCsv>(csv.GetRecords<LinhaCsv>());

            foreach (var ln in linhas)
            {
                batidas.Add(
                    new Marcacao(
                        ln.Id,
                        ln.Nome,
                        DateTime.Parse(ln.Batida))
                 );
            }
        }

        batidas.OrderBy(x => x.Id).ThenByDescending(x => x.Batida);

        return batidas;
    }
}

public record LinhaCsv(int Id, string Nome, string Batida);
using CalculoHoras.App.DTO;
using CalculoHoras.App.Processamento;
using CalculoHoras.Application.DTO;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

namespace CalculoHoras.Application.Processamento;

public class ImportarCSV : Importar
{

    public ImportarCSV(string path, string arquivo) 
        : base(path, arquivo) { }

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

        batidas.OrderBy(x => x.Id)
            .ThenByDescending(x => x.Batida);

        return batidas;
    }
}
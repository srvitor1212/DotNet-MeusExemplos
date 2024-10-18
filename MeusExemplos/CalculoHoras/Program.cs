using CalculoHoras;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

var path = "..\\..\\..\\importar.csv";

var registro = new Record();

var config = new CsvConfiguration(CultureInfo.InvariantCulture)
{
    Delimiter = ";",
    HasHeaderRecord = true
};

var batidas = new List<Marcacao>();

using (var reader = new StreamReader(path))
using (var csv = new CsvReader(reader, config))
{
    var linhas = new List<Record>(csv.GetRecords<Record>());

    foreach (var item in linhas)
    {
        batidas.Add(
            new Marcacao(
                item.Id,
                item.Nome,
                item.Dep,
                DateTime.Parse(item.Batida))
         );
    }
}


var funcionarios = batidas.GroupBy(x => x.Id);

foreach (var func in funcionarios)
{
    Console.WriteLine($"\n\n --- {func.FirstOrDefault()!.Nome} ---");

    var diasComBatida = func.GroupBy(x => x.Batida.Date);

    var saldoDia = new List<SaldoPorDia>();

    foreach (var dia in diasComBatida)
    {
        var entradaSaida = 0;
        var entrada = DateTime.MinValue;
        var saida = DateTime.MinValue;
        var saldo = DateTime.MinValue;

        foreach (var batida in dia)
        {
            if (entradaSaida == 0)
            {
                entrada = batida.Batida;
                entradaSaida = 1;
                continue;
            }

            if (entradaSaida == 1)
            {
                saida = batida.Batida;
                entradaSaida = 0;
            }

            if (entrada != DateTime.MinValue && saida != DateTime.MinValue)
                saldo = saldo + (saida - entrada);
        }

        saldoDia.Add(new SaldoPorDia(dia.Key, saldo));

        Console.WriteLine(
            $"Dia {dia.Key.Date.Day}/{dia.Key.Date.Month}/{dia.Key.Date.Year} {DiaDaSemana.Get(dia.Key)} " +
            $", horas trabalhadas {saldo.Hour}:{saldo.Minute}");
    }

}


Console.ReadKey();

public record SaldoPorDia(DateTime Data, DateTime Saldo);

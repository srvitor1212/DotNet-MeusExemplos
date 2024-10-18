using CalculoHoras;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

var path = "..\\..\\..\\dados\\importar.csv";

var registro = new Record();

var cargaHorariaSemanal = new DateTime(1, 1, 1, 8, 30, 0);
var cargaHorariaSabado = new DateTime(1, 1, 1, 4, 0, 0);

Console.WriteLine($"\n\n" +
    $"Carga horária semanal.: {cargaHorariaSemanal.Hour}:{cargaHorariaSemanal.Minute}\n" +
    $"Carga horária sábado..: {cargaHorariaSabado.Hour}:{cargaHorariaSabado.Minute}");


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
        var horaTrabalhada = DateTime.MinValue;
        var saldo = TimeSpan.MinValue;

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
                horaTrabalhada = horaTrabalhada + (saida - entrada);
        }

        if (dia.Key.DayOfWeek == DayOfWeek.Saturday) //sábado
        {
            saldo = Saldo.Calcular(horaTrabalhada, cargaHorariaSabado);
        } else
        {
            saldo = Saldo.Calcular(horaTrabalhada, cargaHorariaSemanal);
        }

        saldoDia.Add(new SaldoPorDia(dia.Key, horaTrabalhada, saldo));

        Console.WriteLine(
            $"Dia {dia.Key.Date.Day}/{dia.Key.Date.Month}/{dia.Key.Date.Year} {DiaDaSemana.Get(dia.Key)} " +
            $", horas trabalhadas {horaTrabalhada.Hour}:{horaTrabalhada.Minute}" +
            $", saldo {saldo.Hours}:{saldo.Minutes}");
    }

}


Console.ReadKey();

public record SaldoPorDia(DateTime Data, DateTime HoraTrabalhada, TimeSpan Saldo);

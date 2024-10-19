using CalculoHoras.Application.Processamento;


var importar = new ImportarCSV(
    "..\\..\\..\\dados",
    "importar.csv");

var marcacoes = importar.GetMarcacoes();

var cargaHorariaSemanal = new DateTime(1, 1, 1, 8, 30, 0);
var cargaHorariaSabado = new DateTime(1, 1, 1, 4, 0, 0);
var toleranciaExtra = new TimeSpan(0, 5, 59);
var toleranciaFalta = new TimeSpan(0, -5, -59);

var calculo = new CalculoDeHoras(marcacoes, cargaHorariaSemanal, cargaHorariaSabado);

var resultado = calculo.Calcular();


foreach (var item in resultado)
{
    Console.WriteLine($"\n\n" +
        $"--- {item.Nome} ---");

    TimeSpan saldoTotal = TimeSpan.Zero;

    foreach (var dia in item.SaldoPorDias)
    {
        Console.WriteLine($"{dia.Data} {dia.HoraTrabalhada} {dia.Saldo}");

        if (dia.Saldo < toleranciaFalta)
            saldoTotal += dia.Saldo;
        else if (dia.Saldo > toleranciaExtra)
            saldoTotal += dia.Saldo;
    }

    Console.WriteLine($"\n---\n{saldoTotal}");
}


Console.ReadKey();


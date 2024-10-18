using CalculoHoras.app;


var importar = new ImportarCSV(
    "..\\..\\..\\dados",
    "importar.csv");

var marcacoes = importar.GetMarcacoes();

var cargaHorariaSemanal = new DateTime(1, 1, 1, 8, 30, 0);
var cargaHorariaSabado = new DateTime(1, 1, 1, 4, 0, 0);

var calculo = new CalculoDeHoras(marcacoes, cargaHorariaSemanal, cargaHorariaSabado);

var resultado = calculo.Calcular();


Console.ReadKey();


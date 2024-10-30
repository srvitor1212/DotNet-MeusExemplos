using CalculoHoras.App.Processamento;
using CalculoHoras.Application.DTO;
using CalculoHoras.Application.Processamento;


var ambiente = new ConfiguracaoAmbiente();

var importar = new ImportarArquivoTexto(
    ambiente.PathImportar,
    "ID\tNome\tDepart.\tTempo\tNúmero da máquina\t");

var arquivos = BuscarArquivos.GetArquivosParaImportar();

var marcacoes = new List<Marcacao>();

foreach (var arquivo in arquivos)
{
    marcacoes.AddRange(importar.GetMarcacoes(arquivo));
}

var calculo = new CalculoDeHoras(
    marcacoes,
    new TimeSpan(0, 8, 30, 0),
    new TimeSpan(0, 4, 0, 0));

var resultado = calculo.Calcular();

var visualizar = new CalculoDeSaldo(
    resultado, 
    5);

visualizar.ImprimirSaldoConsole();

Console.ReadKey();


using CalculoHoras.App.Processamento;
using CalculoHoras.Application.Processamento;


var arquivoOriginal = new ImportarArquivoTexto(
    @"..\..\..\dados\dados",
    "Registro de atendimento(Funcionário-1).txt",
    "ID\tNome\tDepart.\tTempo\tNúmero da máquina\t");


arquivoOriginal.ImportarArquivo();


var arquivoCsv = new ImportarCSV(
    @"..\..\..\dados",
    "importar.csv");


var marcacoes = arquivoCsv.GetMarcacoes();


var calculo = new CalculoDeHoras(
    marcacoes,
    new DateTime(1, 1, 1, 8, 30, 0),
    new DateTime(1, 1, 1, 4, 0, 0));


var resultado = calculo.Calcular();


var visualizar = new CalculoDeSaldo(resultado, 5);


visualizar.ImprimirSaldoConsole();


Console.ReadKey();

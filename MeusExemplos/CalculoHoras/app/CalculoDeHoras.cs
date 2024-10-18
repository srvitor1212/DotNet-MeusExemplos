namespace CalculoHoras.app;

public class CalculoDeHoras
{
    public List<Marcacao> Marcacoes { get; private set; } = new List<Marcacao>();

    public DateTime CargaHoraria { get; private set; }

    public DateTime CargaHorariaSabado { get; private set; }



    public CalculoDeHoras(List<Marcacao> marcacoes, DateTime cargaHoraria, DateTime cargaHorariaSabado)
    {
        Marcacoes = marcacoes;
        CargaHoraria = cargaHoraria;
        CargaHorariaSabado = cargaHorariaSabado;
    }



    public List<Resultado> Calcular()
    {
        var result = new List<Resultado>();

        var todosOsFuncionarios = Marcacoes.GroupBy(x => x.Id);

        foreach (var funcionario in todosOsFuncionarios)
        {
            var diasComBatida = funcionario.GroupBy(x => x.Batida.Date);

            var horasFuncionario = CalcularHorasFuncionario(diasComBatida);

            result.Add(new Resultado(
                funcionario.FirstOrDefault()!.Id,
                funcionario.FirstOrDefault()!.Nome,
                horasFuncionario));
        }

        return result;
    }

    private List<SaldoPorDia> CalcularHorasFuncionario(IEnumerable<IGrouping<DateTime, Marcacao>> diasComBatida)
    {
        var result = new List<SaldoPorDia>();

        foreach (var dia in diasComBatida)
        {
            var horasNoDia = CalcularHorasDia(dia);

            TimeSpan saldo = TimeSpan.Zero;

            if (dia.Key.DayOfWeek == DayOfWeek.Saturday) //sábado
            {
                saldo = Saldo.Calcular(horasNoDia, CargaHorariaSabado);
            }
            else
            {
                saldo = Saldo.Calcular(horasNoDia, CargaHoraria);
            }

            result.Add(new SaldoPorDia(dia.Key, horasNoDia, saldo));
        }

        return result;
    }

    private DateTime CalcularHorasDia(IGrouping<DateTime, Marcacao> dia)
    {

        var entradaSaida = TipoRegistro.Entrada;
        var entrada = DateTime.MinValue;
        var saida = DateTime.MinValue;

        var horaTrabalhada = DateTime.MinValue;

        foreach (var batida in dia)
        {
            if (entradaSaida == TipoRegistro.Entrada)
            {
                entrada = batida.Batida;
                entradaSaida = Alternar(entradaSaida);
                continue;
            }

            if (entradaSaida == TipoRegistro.Saida)
            {
                saida = batida.Batida;
                entradaSaida = Alternar(entradaSaida);
            }

            if (entrada != DateTime.MinValue && saida != DateTime.MinValue)
                horaTrabalhada = horaTrabalhada + (saida - entrada);
        }

        return horaTrabalhada;
    }


    private static TipoRegistro Alternar(TipoRegistro tipoRegistro)
        => tipoRegistro == TipoRegistro.Entrada
            ? TipoRegistro.Saida
            : TipoRegistro.Entrada;
}

public record SaldoPorDia(DateTime Data, DateTime HoraTrabalhada, TimeSpan Saldo);

public record Resultado(int Id, string Nome, List<SaldoPorDia> SaldoPorDias);

public enum TipoRegistro
{
    Entrada = 0,
    Saida = 1
}


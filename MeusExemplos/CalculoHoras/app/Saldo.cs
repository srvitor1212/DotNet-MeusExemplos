namespace CalculoHoras.app;
public static class Saldo
{
    public static TimeSpan Calcular(DateTime horaTrabalhada, DateTime cargaHoraria)
    {
        var trabalhado = new DateTime(1, 1, 1, horaTrabalhada.Hour, horaTrabalhada.Minute, horaTrabalhada.Second);

        var carga = new DateTime(1, 1, 1, cargaHoraria.Hour, cargaHoraria.Minute, cargaHoraria.Second);

        var result = trabalhado - carga;

        return trabalhado - carga;
    }
}

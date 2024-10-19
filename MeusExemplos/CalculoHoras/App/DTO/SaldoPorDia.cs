namespace CalculoHoras.App.DTO;

public record SaldoPorDia(
    DateTime Data, 
    DateTime HoraTrabalhada, 
    TimeSpan Saldo);

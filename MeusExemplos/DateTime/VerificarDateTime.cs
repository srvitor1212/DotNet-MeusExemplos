namespace DateTime_Ex;
public class VerificarDateTime
{
    public DateTimeOffset DataHora { get; private set; } = DateTimeOffset.UtcNow;


    public void SetDataHora(DateTimeOffset value)
    {
        if (IsDateTimeOffsetUtcNow(value))
        {
            Console.WriteLine($"Recebi no formato correto: {value}");
        }
        else
        {
            value = value.ToUniversalTime();
            Console.WriteLine($"Foi necessário converter: {value}");
        }

        DataHora = value;
    }

    public void SetUniversalTime(DateTimeOffset value) =>
        DataHora = value.ToUniversalTime();

    private bool IsDateTimeOffsetUtcNow(DateTimeOffset value) 
        => value.Offset == TimeSpan.Zero;

}

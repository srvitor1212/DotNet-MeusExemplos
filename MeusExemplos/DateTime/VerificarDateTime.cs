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

    private bool IsDateTimeOffsetUtcNow(DateTimeOffset value) 
        => value.Offset == TimeSpan.Zero;

}

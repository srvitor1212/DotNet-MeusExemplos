namespace Application.Message;

public class ServiceResult
{
    public bool Success { get; private set; }

    public string Message { get; private set; }

    public ServiceResult(bool success, string message)
    {
        Success = success;
        Message = message;
    }

    public static ServiceResult Ok(string? msg = null)
        => new ServiceResult(true, msg ?? string.Empty);

    public static ServiceResult Invalid(string msg)
        => new ServiceResult(false, msg);
}

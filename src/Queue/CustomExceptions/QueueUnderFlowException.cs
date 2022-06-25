namespace Queue.CustomExceptions;

public class QueueUnderFlowException : Exception
{
    public string Message { get; }
    public string Param { get; }
    public QueueUnderFlowException(string param, string message)
    {
        Param = param;
        Message = message;
    }
}
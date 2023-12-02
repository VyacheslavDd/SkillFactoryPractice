namespace MVCAuthentication
{
    public interface ILogger
    {
        Task WriteEvent(string eventMessage);
        Task WriteError(string errorMessage);
    }
}

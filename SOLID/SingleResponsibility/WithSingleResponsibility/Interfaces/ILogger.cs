namespace SingleResponsibility.WithSingleResponsibility.Interfaces
{
    public interface ILogger
    {
        void Info(string info);
        void Debug(string info);
        void Error(string message, Exception ex);
    }
}

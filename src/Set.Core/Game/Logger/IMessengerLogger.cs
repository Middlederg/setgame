namespace Set.Core
{
    public interface IMessengerLogger
    {
        void Error(string message);
        void Info(string message);
        void Warning(string message);

        string GetLastEntry();
    }
}

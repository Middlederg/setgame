namespace Set.Core
{
    public class LogEntry
    {
        public LogEntry(string message, LogType type)
        {
            Message = message;
            Type = type;
        }

        public string Message { get; }
        public LogType Type { get; }
    }
}

using System.Collections.Generic;
using Set.Core;

namespace Set.BlazorApp
{
    public class MessengerLogger : ILogger
    {
        public List<LogEntry> LogEntries { get; private set; }

        public MessengerLogger()
        {
            LogEntries = new List<LogEntry>();
        }

        public void Error(string message) => WriteInLog(message, LogType.Error);
        public void Info(string message) => WriteInLog(message, LogType.Info);
        public void Warning(string message) => WriteInLog(message, LogType.Warning);

        private void WriteInLog(string message, LogType type)
        {
            LogEntries.Add(new LogEntry(message, type));
        }
    }
}

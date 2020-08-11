using System.Collections.Generic;
using System.Linq;
using Set.Core;

namespace Set.Core
{
    public class MessengerLogger : IMessengerLogger
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

        public string GetLastEntry()
        {
            return LogEntries.LastOrDefault()?.Message ?? "";
        }
    }
}

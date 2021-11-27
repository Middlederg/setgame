using System;
using System.Collections.Generic;
using System.Linq;
using Set.Core;

namespace Set.Core
{
    public class MessageLogger
    {
        private readonly Action<string, LogType> onLogWritten;

        public List<LogEntry> LogEntries { get; private set; }

        public MessageLogger(Action<string, LogType> onLogWritten)
        {
            LogEntries = new List<LogEntry>();
            this.onLogWritten = onLogWritten;
        }

        public void Error(string message) => WriteInLog(message, LogType.Error);
        public void Info(string message) => WriteInLog(message, LogType.Info);
        public void Warning(string message) => WriteInLog(message, LogType.Warning);

        private void WriteInLog(string message, LogType type)
        {
            LogEntries.Add(new LogEntry(message, type));
            onLogWritten?.Invoke(message, type);
        }

        public string GetLastEntry()
        {
            return LogEntries.LastOrDefault()?.Message ?? "";
        }
    }
}

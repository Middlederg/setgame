using Set.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Set.xTest
{
    public class TestLogger : IMessengerLogger
    {
        public List<LogEntry> LogEntries { get; private set; }

        public TestLogger()
        {
            LogEntries = new List<LogEntry>();
        }

        public void Error(string message) => WriteInLog(message, LogType.Error);
        public void Info(string message) => WriteInLog(message, LogType.Info);
        public void Warning(string message) => WriteInLog(message, LogType.Warning);

        private void WriteInLog(string message, LogType type) => LogEntries.Add(new LogEntry(message, type));

        public string GetLastEntry()
        {
            throw new NotImplementedException();
        }
    }
}

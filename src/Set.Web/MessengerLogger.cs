using System.Collections.Generic;
using Set.Core;

namespace Set.Web
{
    public class MessengerLogger : IMessengerLogger
    {
        private readonly IMessengerLogger messenger;

        public List<LogEntry> LogEntries { get; private set; }
        public string Message { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public MessengerLogger(IMessengerLogger messenger)
        {
            LogEntries = new List<LogEntry>();
            this.messenger = messenger;
        }

        public void Error(string message) => WriteInLog(message, LogType.Error);
        public void Info(string message) => WriteInLog(message, LogType.Info);
        public void Warning(string message) => WriteInLog(message, LogType.Warning);

        private void WriteInLog(string message, LogType type)
        {
            messenger.Message = message;
            LogEntries.Add(new LogEntry(message, type));
        }
    }
}

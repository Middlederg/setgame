using System.Windows.Forms;
using System.Drawing;
using Set.Core;
using System.Collections.Generic;

namespace Set.Forms
{
    public class WinFormLogger : ILogger
    {
        private ListView lvw;
        public List<LogEntry> LogEntries { get; private set; }

        public WinFormLogger(ListView lvw)
        {
            this.lvw = lvw;
            LogEntries = new List<LogEntry>();
            lvw.Columns.Add(new ColumnHeader() { Text = "Log", Width = 310 });
        }

        public void Error(string message) => WriteInLog(message, LogType.Error);
        public void Info(string message) => WriteInLog(message, LogType.Info);
        public void Warning(string message) => WriteInLog(message, LogType.Warning);

        private void WriteInLog(string message, LogType type)
        {
            var item = new ListViewItem(message)
            {
                ForeColor = type.GetColor()
            };
            lvw.Items.Add(item);
            LogEntries.Add(new LogEntry(message, type));
        }
    }

    public static class LogHelper
    {
        public static Color GetColor(this LogType type)
        {
            switch (type)
            {
                case LogType.Warning: return Color.GreenYellow;
                case LogType.Error: return Color.Red;
                default:
                    return Color.Black;
            }
        }
    }
}
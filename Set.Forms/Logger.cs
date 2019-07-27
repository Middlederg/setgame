using System.Windows.Forms;
using System.Drawing;
using Set.Core;

namespace Set.Forms
{
    public class Logger : ILogger
    {
        private ListView lvw;

        public Logger(ListView lvw)
        {
            this.lvw = lvw;
            lvw.Columns.Add(new ColumnHeader() { Text = "Log" });
        }

        public void Error(string message) => WriteInListView(message, Color.Red);
        public void Info(string message) => WriteInListView(message, Color.Black);
        public void Warning(string message) => WriteInListView(message, Color.GreenYellow);

        private void WriteInListView(string text, Color color)
        {
            var item = new ListViewItem(text)
            {
                ForeColor = color
            };
            lvw.Items.Add(item);
        }
    }
}
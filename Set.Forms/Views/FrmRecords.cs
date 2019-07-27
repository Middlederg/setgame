using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Set.Core;

namespace Set.Forms.Views
{
    public partial class FrmRecords : Form
    {
        private IEnumerable<string> columnHeaders = new string[] { "Jugador", "Puntuación", "# Sets", "# Fallos", "Tiempo" };
        public IEnumerable<Record> RecordList
        {
            get
            {
                foreach (ListViewItem item in Lvw.Items)
                    yield return item.Tag as Record;
            }
            set
            {
                int i = 1;
                foreach (var record in value)
                {
                    ListViewItem item = CreateItem(i, record);
                    Lvw.Items.Add(item);
                    i++;
                }
            }
        }

        public FrmRecords()
        {
            InitializeComponent();
            Lvw.View = View.Details;
            Lvw.Columns.AddRange(columnHeaders.Select(x => CreateColumn(x)).ToArray());
        }

        private ColumnHeader CreateColumn(string header)
        {
            return new ColumnHeader()
            {
                Text = header,
                Width = -2
            };
        }

        private ListViewItem CreateItem(int i, Record record)
        {
            ListViewItem item = new ListViewItem(i.ToString());
            item.SubItems.Add(record.Name);
            item.SubItems.Add(record.Points().ToString());
            item.SubItems.Add(record.Score.SetCount.ToString());
            item.SubItems.Add(record.Score.MistakeCount.ToString());
            item.SubItems.Add(record.Time.ToString());
            item.Tag = record;
            return item;
        }

        private void BtnAceptarClick(object sender, EventArgs e) => Close();
    }
}

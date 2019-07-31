using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Set.Core;

namespace Set.Forms.UserControls
{
    public partial class UcClasificacion : UserControl
    {
        // game.Jugadores.Select(x => (jugador: x, record: new Score(x.NumSets, x.Fallos, segundos))).OrderBy(x => x.record.Points());
        private IEnumerable<string> columnHeaders = new string[] { "#", "Jugador", "Puntuacion", "# Sets", "# Fallos" };
        public IEnumerable<Record> Positions
        {
            get
            {
                foreach (ListViewItem item in Lvw.Items)
                    yield return item.Tag as Record;
            }
            set
            {
                Lvw.Items.Clear();
                int i = 1;
                foreach (var record in value)
                {
                    ListViewItem item = CreateItem(i, record);
                    Lvw.Items.Add(item);
                    i++;
                }
            }
        }

        public UcClasificacion()
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
            item.Tag = record;
            return item;
        }
    }
}

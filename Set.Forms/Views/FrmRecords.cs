using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Set.Core.Model;
using Set.Core.Negocio;

namespace Set.Forms.Views
{
    public partial class FrmRecords : Form
    {
        public FrmRecords()
        {
            InitializeComponent();

            try
            {
                List<Record> l = GameHelper.LeerBestScores();
                LvwPuntos.View = View.Details;

                List<ColumnHeader> columnas = new List<ColumnHeader>();
                foreach (string col in new string[] { "Jugador", "Puntos", "# Sets", "# Fallos", "Tiempo"})
                {
                    columnas.Add(new ColumnHeader
                    {
                        Text = col,
                        Width = -2
                    }); 
                }
                LvwPuntos.Columns.AddRange(columnas.ToArray());

                foreach (Record record in l.OrderByDescending(x => x.Puntuacion()))
                {
                    ListViewItem item = new ListViewItem(record.NombreJugador);
                    item.SubItems.Add(record.Puntuacion().ToString());
                    item.SubItems.Add(record.NumSets.ToString());
                    item.SubItems.Add(record.Fallos.ToString());
                    item.SubItems.Add(record.Tiempo());
                    LvwPuntos.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo acceder al fichero de mejores puntuaciones\n\n" + ex.Message);
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e) => this.Close();
    }
}

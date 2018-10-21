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
    public partial class FrmClasificacion : Form
    {
        public FrmClasificacion(Juego j, int segundos)
        {
            InitializeComponent();

            try
            {
                Lvw.View = View.Details;

                List<ColumnHeader> columnas = new List<ColumnHeader>();
                foreach (string col in new string[] { "#", "Jugador", "Puntuacion", "# Sets", "# Fallos"})
                {
                    columnas.Add(new ColumnHeader
                    {
                        Text = col,
                        Width = -2
                    }); 
                }
                Lvw.Columns.AddRange(columnas.ToArray());

                int i = 1;
                var lista = j.Jugadores.Select(x => (jugador: x, record: new Record(x.NumSets, x.Fallos, segundos))).OrderBy(x => x.record.Puntuacion());
                foreach ((Jugador jug, Record r) in lista)
                {

                    ListViewItem item = new ListViewItem(i.ToString());
                    item.SubItems.Add(jug.Nombre);
                    item.SubItems.Add(r.Puntuacion().ToString());
                    item.SubItems.Add(r.NumSets.ToString());
                    item.SubItems.Add(r.Fallos.ToString());
                    Lvw.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo mostrar la clasificación" + ex.Message);
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e) => this.Close();
    }
}

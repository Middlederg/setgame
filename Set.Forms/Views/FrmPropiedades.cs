using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Set.Core;
using Set.Core.Negocio;

namespace Set.Forms.Views
{
    public partial class FrmPropiedades : Form
    {
        public FrmPropiedades()
        {
            InitializeComponent();

            CmbDificultad.DataSource = Util.GetEnumList<Dificultad>();
            CmbDificultad.SelectedIndex = 0;
            LlenarNombres();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Visible = false;
            Dificultad dificultad = (Dificultad)CmbDificultad.SelectedItem;
            int numCartas = (int)NudNumCartas.Value;
            new FrmPrincipal(dificultad, numCartas, NombresEnLista()).ShowDialog();
            Close();
        }

        private void BtnVolver_Click(object sender, EventArgs e) => Close();

        private void CmbDificultad_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dificultad = (Dificultad)CmbDificultad.SelectedItem;
            NudNumCartas.Maximum = dificultad.NumeroMaximo();
            new ToolTip().SetToolTip(CmbDificultad, dificultad.Descripcion());
        }

        private void NudJugadores_ValueChanged(object sender, EventArgs e)
        {
            if (NudJugadores.Value == 1)
            {
                pPrincipal.RowStyles[5].Height = 0;
                Height = 220;
                LvwNombres.Items.Clear();
                LvwNombres.Items.Add(string.Empty);
            }
            else
            {
                pPrincipal.RowStyles[5].Height = 80;
                Height = 300;
                LlenarNombres();
            }
        }

        private void LlenarNombres()
        {
            LvwNombres.Items.Clear();
            if (NudJugadores.Value != 0)
                foreach (var num in Enumerable.Range(0, (int)NudJugadores.Value))
                    LvwNombres.Items.Add(Files.NombreAleatorio(NombresEnLista().ToList()));
        }

        private IEnumerable<string> NombresEnLista(bool minusc = false)
        {
            foreach (ListViewItem item in LvwNombres.Items)
                yield return minusc ? item.Text.Simplify() : item.Text.Trim();
        }

        private void LabelEditado(object sender, LabelEditEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(e.Label) || NombresEnLista(true).Contains(e.Label.Simplify()))
            {
                MessageBox.Show("No se pueden duplicar nombres");
                e.CancelEdit = true;
            }
        }
    }
}

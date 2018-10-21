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
    public partial class FrmInputName : Form
    {
        Record record;

        public FrmInputName(int sets, int fallos, int segundos)
        {
            InitializeComponent();
            record = new Record(sets, fallos, segundos);
            LblSets.Text = $"{sets} / {fallos}";
            LblTiempo.Text = record.Tiempo.ToString();
            LblPuntuacion.Text = record.Puntuacion().ToString() + " puntos";
        }

        private void BtnAceptar_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbNombre.Text))
            {
                record.NombreJugador = tbNombre.Text;
                try
                {
                    GameHelper.GuardarPuntuacion(record);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar la puntuación\n\n" + ex.Message);
                }
                Close();
            }
            else
                MessageBox.Show("Escribe tu nombre para guardar la puntuación obtenida");
        }
    }
}

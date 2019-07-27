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

namespace Set.Forms.Views
{
    public partial class FrmInputName : Form
    {
        public string InputName
        {
            get => TbxNombre.Text.Trim();
            set => TbxNombre.Text = value;
        }

        public FrmInputName(int sets, int fallos, int segundos)
        {
            InitializeComponent();
            var time = new Time(segundos);
            var score = Score.Create(sets, fallos);
            LblSets.Text = $"{score.SetCount} / {score.MistakeCount}";
            LblTiempo.Text = time.ToString();
            LblPuntuacion.Text = $"{score.Points(time)} puntos";
        }

        private void BtnAceptarClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TbxNombre.Text))
            {
                Close();
            }
            else MessageBox.Show("Escribe tu nombre para guardar la puntuación obtenida");
        }
    }
}

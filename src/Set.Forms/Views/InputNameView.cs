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
using Set.Core.ViewModels;

namespace Set.Forms.Views
{
    public partial class InputNameView : Form, IPlayerNameViewModel
    {
        public string InputName
        {
            get => TbxNombre.Text.Trim();
            set => TbxNombre.Text = value;
        }

        public void SetInfo(Score score, Time time)
        {
            LblSets.Text = $"{score.SetCount} / {score.MistakeCount}";
            LblTiempo.Text = time.ToString();
            LblPuntuacion.Text = $"{score.Points()} puntos";
        }

        public InputNameView()
        {
            InitializeComponent();
        }

        private void BtnAceptarClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TbxNombre.Text))
            {
                Close();
            }
            else MessageBox.Show("Escribe tu nombre para guardar la puntuación obtenida");
        }

        public bool ShowWindow()
        {
            ShowDialog();
            return true;
        }
    }
}

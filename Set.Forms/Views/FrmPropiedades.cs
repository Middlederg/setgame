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
    public partial class FrmPropiedades : Form
    {
        public FrmPropiedades()
        {
            InitializeComponent();

            CmbDificultad.DataSource = General.GetEnumList<Dificultad>();
            CmbDificultad.SelectedIndex = 0;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Visible = false;
            Dificultad dificultad = (Dificultad)CmbDificultad.SelectedItem;
            int numCartas = (int)DudNumCartas.Value;
            new FrmPrincipal(dificultad, numCartas).ShowDialog();
            Close();
        }

        private void BtnVolver_Click(object sender, EventArgs e) => Close();
    }
}

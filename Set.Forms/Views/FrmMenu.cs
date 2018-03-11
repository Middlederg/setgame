using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Set.Forms.Views
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            Visible = false;
            new FrmPropiedades().ShowDialog();
            Visible = true;
        }

        private void BtnInstrucciones_Click(object sender, EventArgs e) 
            => System.Diagnostics.Process.Start("http://www.tocamates.com/set-jugando-a-hacer-conjuntos/");

        private void BtnRecords_Click(object sender, EventArgs e) => new FrmRecords().ShowDialog();
        

        private void BtnClose_Click(object sender, EventArgs e) => Application.Exit();
        private void BtnMin_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;
        private void BtnMax_Click(object sender, EventArgs e) => WindowState = WindowState.Equals(FormWindowState.Maximized) ?
            FormWindowState.Normal : FormWindowState.Maximized;


    }
}

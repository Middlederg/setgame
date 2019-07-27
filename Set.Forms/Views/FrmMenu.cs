using Set.Core;
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
            using (var view = new FrmPropiedades())
            {
                view.ShowDialog();
                if (view.ShowDialog() == DialogResult.OK)
                {
                    var gameOptions = new GameOptions(view.CardNumber, view.GameMode, view.GetPlayersNames);
                    using (var principalView = new FrmPrincipal(gameOptions))
                    {
                        principalView.ShowDialog();
                    }
                }
            }
            Visible = true;
        }

        private void BtnInstruccionesClick(object sender, EventArgs e) => System.Diagnostics.Process.Start("http://www.tocamates.com/set-jugando-a-hacer-conjuntos/");

        private void BtnRecordsClick(object sender, EventArgs e)
        {
            using (var view = new FrmRecords())
            {
                view.ShowDialog();
            }
        }

        private void BtnCloseClick(object sender, EventArgs e) => Application.Exit();
        private void BtnMinClick(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;
    }
}

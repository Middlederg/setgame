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
    public partial class MenuView : Form
    {
        public MenuView()
        {
            InitializeComponent();
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            Visible = false;
            using (var view = new GameSettingsView())
            {
                if (view.ShowDialog() == DialogResult.OK)
                {
                    var gameOptions = new GameOptions(view.CardNumber, view.GameMode, view.GetPlayersNames.ToArray());
                    using (var principalView = new MainView(gameOptions))
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
            using (var view = new RecordListView())
            {
                view.ShowDialog();
            }
        }

        private void BtnCloseClick(object sender, EventArgs e) => Application.Exit();
        private void BtnMinClick(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;
    }
}

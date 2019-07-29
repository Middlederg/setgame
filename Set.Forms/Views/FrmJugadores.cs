using Set.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Set.Forms.Views
{
    public partial class FrmJugadores : Form
    {
        private IEnumerable<Player> players;
        public Player SelectedPlayer { get; private set; }

        public FrmJugadores(List<Player> players)
        {
            InitializeComponent();

            int indx = 0;
            foreach (var player in players)
            {
                var btn = new CustomButton()
                {
                    Text = player.ToString(),
                    Dock = DockStyle.Top,
                    Height = pGeneral.Height / players.Count,
                    TabIndex = indx++,
                    Padding = new Padding(15, 5, 15, 5),
                    Font = new Font("Console", 10, FontStyle.Bold),
                    Tag = player
                };
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(99, 110, 114);
                btn.Click += OnButtonClicked;
                pGeneral.Controls.Add(btn);
            }
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            SelectedPlayer = ((Control)sender).Tag as Player;
            Close();
        }
    }
}

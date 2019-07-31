using Set.Core;
using Set.Core.ViewModels;
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
    public partial class PlayersView : Form, IPlayersViewModel
    {
        public IEnumerable<Player> Players
        {
            get
            {
                foreach (var button in pGeneral.Controls.OfType<CustomButton>())
                    yield return button.Tag as Player;
            }
            set
            {
                int indx = 0;
                foreach (var player in value)
                {
                    var btn = new CustomButton()
                    {
                        Text = player.ToString(),
                        Dock = DockStyle.Top,
                        Height = pGeneral.Height / value.Count(),
                        TabIndex = indx++,
                        Padding = new Padding(15, 5, 15, 5),
                        Font = new Font("Console", 10, FontStyle.Bold),
                        Tag = player
                    };
                    btn.Click += OnButtonClicked;
                    pGeneral.Controls.Add(btn);
                }
            }
        }
        public Player SelectedPlayer { get; private set; }

        public PlayersView()
        {
            InitializeComponent();            
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            SelectedPlayer = ((Control)sender).Tag as Player;
            Close();
        }

        public bool ShowWindow()
        {
            ShowDialog();
            return true;
        }
    }
}

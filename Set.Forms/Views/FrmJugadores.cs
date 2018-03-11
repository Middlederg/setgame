using Set.Core.Model;
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
        public int BotonSeleccionado { get; set; }

        public FrmJugadores(List<Jugador> jugadores)
        {
            InitializeComponent();

            int indx = 0;
            foreach (var jug in jugadores)
            {
                Button btn = new Button()
                {
                    Text = jug.Nombre,
                    Dock = DockStyle.Top,
                    Height = pGeneral.Height / jugadores.Count,
                    TabIndex = indx,
                    Padding = new Padding(15, 5, 15, 5),
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.FromArgb(45, 52, 54),
                    ForeColor = Color.FromArgb(129, 236, 236),
                    Font = new Font("Console", 10, FontStyle.Bold)
                };
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(99, 110, 114);
                indx++;
                btn.Click += Btn_Click;
                pGeneral.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            BotonSeleccionado = ((Control)sender).TabIndex;
            Close();
        }
    }
}

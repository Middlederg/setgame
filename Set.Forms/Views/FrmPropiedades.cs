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
    public partial class FrmPropiedades : Form
    {
        public GameMode GameMode
        {
            get => GameModeCombo.SelectedItem as GameMode;
            set => GameModeCombo.SelectedItem = value;
        }

        public int CardNumber
        {
            get => (int)CardNumberSelector.Value;
            set => CardNumberSelector.Value = value;
        }

        public int PlayerNumberCount => (int)PlayerNumberSelector.Value;

        public IEnumerable<string> GetPlayersNames => LvwNombres.Items.OfType<ListViewItem>().Select(x => x.Text.Trim());

        public FrmPropiedades()
        {
            InitializeComponent();

            GameModeCombo.DataSource = new List<GameMode>() { GameModeFactory.Tutorial, GameModeFactory.Easy, GameModeFactory.Regular };
            GameModeCombo.SelectedIndex = 0;
        }

        private void CmbDificultad_SelectedIndexChanged(object sender, EventArgs e)
        {
            var gameMode = (GameMode)GameModeCombo.SelectedItem;
            if (CardNumberSelector.Value > GameMode.MaxCardNumber)
                CardNumberSelector.Value = GameMode.MaxCardNumber;
            CardNumberSelector.Maximum = gameMode.MaxCardNumber;
            new ToolTip().SetToolTip(GameModeCombo, gameMode.Description);
        }

        private void NudJugadores_ValueChanged(object sender, EventArgs e)
        {
            if (PlayerNumberSelector.Value == 1)
            {
                pPrincipal.RowStyles[5].Height = 0;
                Height = 220;
            }
            else
            {
                pPrincipal.RowStyles[5].Height = 80;
                Height = 300;
                LlenarNombres();
            }
        }

        private void LlenarNombres()
        {
            LvwNombres.Items.Clear();
            foreach (var i in Enumerable.Range(0, (int)PlayerNumberSelector.Value))
                LvwNombres.Items.Add(NameFactory.GetRandomName(GetPlayersNames));
        }

        private void LabelEditado(object sender, LabelEditEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(e.Label))
            {
                MessageBox.Show("El nombre del jugador no puede estar vacío");
                e.CancelEdit = true;
            }

            if (GetPlayersNames.Select(x => x.Simplify()).Contains(e.Label.Simplify()))
            {
                MessageBox.Show("El nombre del jugador ya existe");
                e.CancelEdit = true;
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

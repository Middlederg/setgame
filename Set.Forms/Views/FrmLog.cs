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
    public partial class FrmLog : Form
    {
        public FrmLog(IEnumerable<string> log)
        {
            InitializeComponent();

            foreach (string logEntry in log)
                LbxLog.Items.Add(logEntry);
        }

        private void BtnAceptar_Click(object sender, EventArgs e) => Close();
    }
}

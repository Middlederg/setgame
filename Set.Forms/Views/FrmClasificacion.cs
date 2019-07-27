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
using Set.Core.Negocio;

namespace Set.Forms.Views
{
    public partial class FrmClasificacion : Form
    {
      

        public FrmClasificacion()
        {
            InitializeComponent();
            
        }

     

        private void BtnAceptarClick(object sender, EventArgs e) => Close();
    }
}

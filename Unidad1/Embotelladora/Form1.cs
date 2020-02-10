using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Embotelladora
{
    public partial class frmembotelladora : Form
    {
        public frmembotelladora()
        {
            InitializeComponent();
        }

        public void btnverificar_Click(object sender, EventArgs e)
        {
            Classbotella objbotella = new Classbotella();

            objbotella.nivelLlenado = Convert.ToInt32(txtniveldellenado.Text);
            MessageBox.Show (objbotella.VerificarLlenado());
        }

        private void txtniveldellenado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

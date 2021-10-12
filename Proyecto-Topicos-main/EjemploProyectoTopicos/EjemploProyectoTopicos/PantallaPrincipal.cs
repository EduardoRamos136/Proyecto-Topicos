using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploProyectoTopicos
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnBinario_Click(object sender, EventArgs e)
        {
            frmBinario FormBinario = new frmBinario();
            this.Hide();
            FormBinario.Show();
        }

        private void btnOctal_Click(object sender, EventArgs e)
        {
            frmOctal FormOctal = new frmOctal();
            this.Hide();
            FormOctal.Show();
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            frmDecimal FormDecimal = new frmDecimal();
            this.Hide();
            FormDecimal.Show();
        }

        private void btnHexadecimal_Click(object sender, EventArgs e)
        {
            frmHexadecimal FormHexadecimal = new frmHexadecimal();
            this.Hide();
            FormHexadecimal.Show();
        }
    }
}

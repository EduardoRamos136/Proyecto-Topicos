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
    public partial class frmBinario : Form
    {
        public frmBinario()
        {
            InitializeComponent();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtBin.Clear();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmPrincipal FormPrincipal = new frmPrincipal();
            this.Hide();
            FormPrincipal.Show();
        }
    }
}

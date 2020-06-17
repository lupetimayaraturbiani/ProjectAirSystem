using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste1.Views
{
    public partial class frmPrincipalAdm : Form
    {
        public frmPrincipalAdm()
        {
            InitializeComponent();
        }

        private void btnListaAvioes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bem Vindo", "Entrada");
            new frmListarUsuarios().ShowDialog();
        }
    }
}

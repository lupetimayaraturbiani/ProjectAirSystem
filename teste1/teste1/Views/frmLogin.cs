using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using teste1.Models;
using teste1.Repositories;
using teste1.Views;

namespace teste1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = this.Size;
            this.Text = "Login | AirSystem";


            usuarioTextBox.ShortcutsEnabled = false;
        }


        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            new frmCadastro().ShowDialog();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            
            if (usuarioTextBox.Text.Trim().Length == 0)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Os campos de usuário e senha precisam ser preenchidos", "Erro");
            }
            else
            {
                //Usuario usuario = new Usuario();
                //    if (u.adm == true)
                //    {
                            //MessageBox.Show("Bem Vindo Administrador", "Entrada");
                            //new frmPrincipalAdm().ShowDialog();
                //    }

                MessageBox.Show("Bem Vindo", "Entrada");
                new frmPrincipal().ShowDialog();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblCaps.Visible = isCapsLockActive();
        }

        private void usuarioTextBox_Enter(object sender, EventArgs e)
        {
            lblCaps.Visible = isCapsLockActive();
        }
        

        private bool isCapsLockActive()
        {
            return Control.IsKeyLocked(Keys.CapsLock);
        }

        private void usuarioTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            lblCaps.Visible = isCapsLockActive();
        }

        private void usuarioTextBox_Leave(object sender, EventArgs e)
        {
            lblCaps.Visible = false;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblRelogio2.Text = DateTime.Now.ToString("HH:mm:ss:fff");
        }

        private void btnAdm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bem Vindo Administrador", "Entrada");
            new frmListarUsuarios().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Tem certeza de que deseja sair?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                this.Close();

                Application.Exit();
            }
        }
    }

}

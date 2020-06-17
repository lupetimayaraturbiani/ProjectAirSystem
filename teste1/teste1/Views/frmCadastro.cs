using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using teste1.Models;
using teste1.Repositories;

namespace teste1
{
    public partial class frmCadastro : Form
    {
        private Usuario usuario = null;

        public frmCadastro()
        {
            InitializeComponent();
        }

        // -------------- o frmCadastro dava erro e eu não sei o motivo, comentei pra poder compilar--------------------------//
        //public frmCadastro(Usuario usuario)
        //{
        //InitializeComponent();

        //this.usuario = usuario;
        //}
        //--------------------------------------------------------------------------------------------------------------------//


       // private void Inputs_Leave(object sender, EventArgs e)
       // {
       //     TextBox txt = sender as TextBox;
       //     if (txt != null)
       //     {
       //         txt.BackColor = Color.White;

       //         if (txt.Text == "")
       //         {
       //             txt.Text = "Digite - " + txt.AccessibleName;
       //         }

       //     }
       // }


       //private void Inputs_Enter(object sender, EventArgs e)
       // {
       //     TextBox txt = sender as TextBox;
       //     if (txt != null)
       //     {
       //         txt.BackColor = Color.LightYellow;
       //         string value = txt.Text;
       //         if (value.Substring(0, 8) == "Digite -") 
       //         {
       //             txt.Text = "";
       //         }
       //     }
       // }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!Utils.temCamposVazios(this))
            {
                UsuarioRepository repository = new UsuarioRepository();
                if (this.usuario == null)
                {
                    Usuario usuario = new Usuario
                    {
                        nome = nomeTextBox.Text,
                        sobrenome = sobrenomeTextBox.Text,
                        endereco = enderecoTextBox.Text,
                        numero = numeroTextBox.Text,
                        usuario = usuarioTextBox.Text,
                        senha = senhaTextBox.Text,
                        adm = adminCheckBox.AutoCheck
                    };

                    if (confirmaSenhaTextBox.Text == senhaTextBox.Text)
                    {

                        if (senhaTextBox.TextLength >= 8)
                        {
                            bool isSenhaValid;
                            string pattern = "[a-z]{1,}[1,9]{1,}[A-Z]{1,}";
                            isSenhaValid = Regex.IsMatch(senhaTextBox.Text, pattern);

                            repository.adicionar(usuario);


                                MessageBox.Show("Dados Salvos.",
                                            "Aviso", MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("A senha deve conter pelo menos 8 caracteres com " +
                                "pelo menos uma letra maúscula, uma letra minúscula e um número",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        MessageBox.Show("A senha e sua confirmação deve ser iguais",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                   

                }
                else
                {
                    this.usuario.nome = nomeTextBox.Text;
                    this.usuario.sobrenome = sobrenomeTextBox.Text;
                    this.usuario.endereco = enderecoTextBox.Text;
                    this.usuario.numero = numeroTextBox.Text;
                    this.usuario.usuario = usuarioTextBox.Text;
                    this.usuario.senha = senhaTextBox.Text;
                    this.usuario.adm = adminCheckBox.AutoCheck;

                    repository.editar(usuario);
                }
                this.Close();


                
            }
            else
            {
                MessageBox.Show("Todos os campos são obrigatórios.",
                                "Aviso", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }


        private bool isSenhaValid(string senha)
        {
            if (senha.Length >= 8)
            {
                string pattern = "[a-z]{1,}";
                if (Regex.IsMatch(senha, pattern))
                {
                    pattern = "[A-Z]{1,0}";

                    if (Regex.IsMatch(senha, pattern))
                    {
                        pattern = "[0-9]{1,0}";

                        if (Regex.IsMatch(senha, pattern))
                        {
                            return true;
                        }

                    }
                }
            }

            return false;
        }


        private void senhaTextBox_TextChanged(object sender, EventArgs e)
        {
            
            

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Arquivos de imagens(*.jpg;*.png)|*.jpg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fotoPictureBox.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {

            if (fotoPictureBox.Image != null)
            {
                fotoPictureBox.Image.Dispose();
                fotoPictureBox.Image = null;
            }

            
        }

        private void adminCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            if (adminCheckBox.Checked)
            {
                usuario.adm = true;
            }

            usuario.adm = false;
        }

        
    }


    

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using teste1.Models;
using teste1.Repositories;

namespace teste1.Views
{
    public partial class frmListarUsuarios : Form
    {
        UsuarioRepository repository = new UsuarioRepository();
        public frmListarUsuarios()
        {
            InitializeComponent();
        }

        private void frmListaUsuario_Load(object sender, EventArgs e)
        {
            // cchama o método para carregar o datagrid
            carregaLista();
        }

        private void carregaLista()
        {
            // chama o repositório
            UsuarioRepository repository = new UsuarioRepository();
            // usa o método para buscar todos os usuários e carrega-los
            dgvListaUsuario.DataSource = null;
            dgvListaUsuario.DataSource = repository.buscarTodos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new frmCadastro().ShowDialog();
            carregaLista();
        }

        private void dgvListaUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow linha = dgvListaUsuario.Rows[e.RowIndex];

            string nome = linha.Cells[1].Value.ToString();
            string sobrenome = linha.Cells[2].Value.ToString();
            string endereco = linha.Cells[3].Value.ToString();
            string numero = linha.Cells[4].Value.ToString();
            string userName = linha.Cells[5].Value.ToString();
            string senha = linha.Cells[6].Value.ToString();

            int id = Convert.ToInt32(linha.Cells[0].Value.ToString());

                Usuario usuario = new Usuario
                {
                    id = id,
                    nome = nome,
                    sobrenome = sobrenome,
                    endereco = endereco,
                    numero = numero,
                    usuario = userName,
                    senha = senha
                };

            //new frmCadastro(usuario).ShowDialog();

            carregaLista();
        }

        private void btnDeletar2_Click(object sender, DataGridViewCellEventArgs e)
        {
            Usuario usuario = new Usuario();
            if (usuario != null)
            {
                DialogResult dr = MessageBox.Show("Deseja excluir este usuário?", "Atenção"
                                    , MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    DataGridViewRow linha = dgvListaUsuario.Rows[e.RowIndex];

                    int id = Convert.ToInt32(linha.Cells[0].Value.ToString());

                    repository.deletar(id);

                    carregaLista();
                }
            }

            MessageBox.Show("Esse usuário não existe", "Atenção");
        }

        private void nomeFiltroTextBox_TextChanged(object sender, EventArgs e)
        {
            dgvListaUsuario.DataSource = null;


            dgvListaUsuario.DataSource = repository.buscarTodos().FindAll(x =>
                x.nome.ToUpper().Contains(nomeFiltroTextBox.Text.ToUpper()) ||
                x.sobrenome.ToUpper().Contains(nomeFiltroTextBox.Text.ToUpper())
            );
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem ceretza que quer fechar?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

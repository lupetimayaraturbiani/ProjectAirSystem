namespace teste1.Views
{
    partial class frmListarUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvListaUsuario = new System.Windows.Forms.DataGridView();
            this.idCloumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobrenomeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblDados = new System.Windows.Forms.Label();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sobrenomeTextBox = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nascimentoTextBox = new System.Windows.Forms.TextBox();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.confirmaSenhaTextBox = new System.Windows.Forms.TextBox();
            this.lblConfirmaSenha = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDeletar2 = new System.Windows.Forms.Button();
            this.nomeFiltroTextBox = new System.Windows.Forms.TextBox();
            this.lblNomeFiltro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaUsuario
            // 
            this.dgvListaUsuario.BackgroundColor = System.Drawing.Color.DarkOrchid;
            this.dgvListaUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCloumn,
            this.nomeColumn,
            this.sobrenomeColumn});
            this.dgvListaUsuario.Location = new System.Drawing.Point(-2, -3);
            this.dgvListaUsuario.Name = "dgvListaUsuario";
            this.dgvListaUsuario.Size = new System.Drawing.Size(337, 521);
            this.dgvListaUsuario.TabIndex = 0;
            // 
            // idCloumn
            // 
            this.idCloumn.HeaderText = "ID";
            this.idCloumn.Name = "idCloumn";
            // 
            // nomeColumn
            // 
            this.nomeColumn.HeaderText = "Nome";
            this.nomeColumn.Name = "nomeColumn";
            // 
            // sobrenomeColumn
            // 
            this.sobrenomeColumn.HeaderText = "Sobrenome";
            this.sobrenomeColumn.Name = "sobrenomeColumn";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUsuario.Location = new System.Drawing.Point(373, 484);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(48, 15);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuário";
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDados.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDados.Location = new System.Drawing.Point(528, 23);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(145, 23);
            this.lblDados.TabIndex = 2;
            this.lblDados.Text = "Dados do usuário";
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.fotoPictureBox.Location = new System.Drawing.Point(487, 72);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(228, 189);
            this.fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoPictureBox.TabIndex = 3;
            this.fotoPictureBox.TabStop = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNome.Location = new System.Drawing.Point(373, 298);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(475, 293);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(253, 20);
            this.nomeTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(373, 442);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Número";
            // 
            // sobrenomeTextBox
            // 
            this.sobrenomeTextBox.Location = new System.Drawing.Point(475, 328);
            this.sobrenomeTextBox.Name = "sobrenomeTextBox";
            this.sobrenomeTextBox.Size = new System.Drawing.Size(254, 20);
            this.sobrenomeTextBox.TabIndex = 7;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEndereco.Location = new System.Drawing.Point(371, 367);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(57, 15);
            this.lblEndereco.TabIndex = 8;
            this.lblEndereco.Text = "Endereço";
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.Location = new System.Drawing.Point(475, 365);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(254, 20);
            this.enderecoTextBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(371, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nascimento";
            // 
            // nascimentoTextBox
            // 
            this.nascimentoTextBox.Location = new System.Drawing.Point(475, 402);
            this.nascimentoTextBox.Name = "nascimentoTextBox";
            this.nascimentoTextBox.Size = new System.Drawing.Size(254, 20);
            this.nascimentoTextBox.TabIndex = 11;
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobrenome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSobrenome.Location = new System.Drawing.Point(371, 330);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(69, 15);
            this.lblSobrenome.TabIndex = 12;
            this.lblSobrenome.Text = "Sobrenome";
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.Location = new System.Drawing.Point(475, 440);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(256, 20);
            this.numeroTextBox.TabIndex = 13;
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.Location = new System.Drawing.Point(475, 479);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(256, 20);
            this.usuarioTextBox.TabIndex = 14;
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.Location = new System.Drawing.Point(475, 519);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(256, 20);
            this.senhaTextBox.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(373, 521);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Senha";
            // 
            // confirmaSenhaTextBox
            // 
            this.confirmaSenhaTextBox.Location = new System.Drawing.Point(475, 556);
            this.confirmaSenhaTextBox.Name = "confirmaSenhaTextBox";
            this.confirmaSenhaTextBox.Size = new System.Drawing.Size(256, 20);
            this.confirmaSenhaTextBox.TabIndex = 17;
            // 
            // lblConfirmaSenha
            // 
            this.lblConfirmaSenha.AutoSize = true;
            this.lblConfirmaSenha.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmaSenha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblConfirmaSenha.Location = new System.Drawing.Point(371, 558);
            this.lblConfirmaSenha.Name = "lblConfirmaSenha";
            this.lblConfirmaSenha.Size = new System.Drawing.Size(93, 15);
            this.lblConfirmaSenha.TabIndex = 18;
            this.lblConfirmaSenha.Text = "Confirma Senha";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(368, 165);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 19;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Location = new System.Drawing.Point(749, 165);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 20;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(365, 606);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 21;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(500, 606);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 22;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(598, 606);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 23;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnDeletar2
            // 
            this.btnDeletar2.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar2.Location = new System.Drawing.Point(694, 606);
            this.btnDeletar2.Name = "btnDeletar2";
            this.btnDeletar2.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar2.TabIndex = 24;
            this.btnDeletar2.Text = "Deletar";
            this.btnDeletar2.UseVisualStyleBackColor = true;
            // 
            // nomeFiltroTextBox
            // 
            this.nomeFiltroTextBox.Location = new System.Drawing.Point(74, 604);
            this.nomeFiltroTextBox.Name = "nomeFiltroTextBox";
            this.nomeFiltroTextBox.Size = new System.Drawing.Size(215, 20);
            this.nomeFiltroTextBox.TabIndex = 25;
            this.nomeFiltroTextBox.TextChanged += new System.EventHandler(this.nomeFiltroTextBox_TextChanged);
            // 
            // lblNomeFiltro
            // 
            this.lblNomeFiltro.AutoSize = true;
            this.lblNomeFiltro.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFiltro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNomeFiltro.Location = new System.Drawing.Point(12, 606);
            this.lblNomeFiltro.Name = "lblNomeFiltro";
            this.lblNomeFiltro.Size = new System.Drawing.Size(40, 15);
            this.lblNomeFiltro.TabIndex = 26;
            this.lblNomeFiltro.Text = "Nome";
            // 
            // frmListarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(847, 681);
            this.Controls.Add(this.lblNomeFiltro);
            this.Controls.Add(this.nomeFiltroTextBox);
            this.Controls.Add(this.btnDeletar2);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.lblConfirmaSenha);
            this.Controls.Add(this.confirmaSenhaTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(this.usuarioTextBox);
            this.Controls.Add(this.numeroTextBox);
            this.Controls.Add(this.lblSobrenome);
            this.Controls.Add(this.nascimentoTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.sobrenomeTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.fotoPictureBox);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.dgvListaUsuario);
            this.Name = "frmListarUsuarios";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCloumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobrenomeColumn;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblDados;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sobrenomeTextBox;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nascimentoTextBox;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.TextBox numeroTextBox;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox confirmaSenhaTextBox;
        private System.Windows.Forms.Label lblConfirmaSenha;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeletar2;
        private System.Windows.Forms.TextBox nomeFiltroTextBox;
        private System.Windows.Forms.Label lblNomeFiltro;
    }
}
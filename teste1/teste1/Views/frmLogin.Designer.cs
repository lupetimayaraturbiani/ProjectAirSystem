namespace teste1
{
    partial class frmLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.idiomaBox = new System.Windows.Forms.ComboBox();
            this.loginPictureBox = new System.Windows.Forms.PictureBox();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNovoUsuario = new System.Windows.Forms.Button();
            this.lblCaps = new System.Windows.Forms.Label();
            this.lblRelogio = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblRelogio2 = new System.Windows.Forms.Label();
            this.btnAdm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.loginPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // idiomaBox
            // 
            this.idiomaBox.DisplayMember = " ";
            this.idiomaBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idiomaBox.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idiomaBox.FormattingEnabled = true;
            this.idiomaBox.ItemHeight = 15;
            this.idiomaBox.Items.AddRange(new object[] {
            "Português PT-BR",
            "Inglês UK-US"});
            this.idiomaBox.Location = new System.Drawing.Point(548, 421);
            this.idiomaBox.Name = "idiomaBox";
            this.idiomaBox.Size = new System.Drawing.Size(153, 23);
            this.idiomaBox.TabIndex = 0;
            this.idiomaBox.Tag = "";
            this.idiomaBox.ValueMember = " ";
            // 
            // loginPictureBox
            // 
            this.loginPictureBox.Image = global::teste1.Properties.Resources.login;
            this.loginPictureBox.Location = new System.Drawing.Point(41, 97);
            this.loginPictureBox.Name = "loginPictureBox";
            this.loginPictureBox.Size = new System.Drawing.Size(413, 347);
            this.loginPictureBox.TabIndex = 1;
            this.loginPictureBox.TabStop = false;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::teste1.Properties.Resources.logoAirSystem2;
            this.logoPictureBox.Location = new System.Drawing.Point(548, 42);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(319, 201);
            this.logoPictureBox.TabIndex = 2;
            this.logoPictureBox.TabStop = false;
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioTextBox.Location = new System.Drawing.Point(548, 289);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(319, 21);
            this.usuarioTextBox.TabIndex = 3;
            this.usuarioTextBox.Text = "Digite o seu usuário\r\n\r\n\r\n";
            this.usuarioTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usuarioTextBox_KeyDown);
            this.usuarioTextBox.Leave += new System.EventHandler(this.usuarioTextBox_Leave);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUsuario.Location = new System.Drawing.Point(544, 255);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(80, 23);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuário:";
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaTextBox.Location = new System.Drawing.Point(548, 355);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.PasswordChar = '$';
            this.senhaTextBox.Size = new System.Drawing.Size(319, 21);
            this.senhaTextBox.TabIndex = 5;
            this.senhaTextBox.Text = "Digite sua senha";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSenha.Location = new System.Drawing.Point(544, 320);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(69, 23);
            this.lblSenha.TabIndex = 6;
            this.lblSenha.Text = "Senha:";
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdioma.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIdioma.Location = new System.Drawing.Point(544, 383);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(74, 23);
            this.lblIdioma.TabIndex = 7;
            this.lblIdioma.Text = "Idioma:";
            // 
            // buttonEnter
            // 
            this.buttonEnter.BackColor = System.Drawing.SystemColors.Control;
            this.buttonEnter.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnter.Location = new System.Drawing.Point(514, 470);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(84, 29);
            this.buttonEnter.TabIndex = 8;
            this.buttonEnter.Text = "Entrar";
            this.buttonEnter.UseVisualStyleBackColor = false;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(604, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNovoUsuario
            // 
            this.btnNovoUsuario.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoUsuario.Location = new System.Drawing.Point(692, 470);
            this.btnNovoUsuario.Name = "btnNovoUsuario";
            this.btnNovoUsuario.Size = new System.Drawing.Size(175, 29);
            this.btnNovoUsuario.TabIndex = 10;
            this.btnNovoUsuario.Text = "Novo usuário";
            this.btnNovoUsuario.UseVisualStyleBackColor = true;
            this.btnNovoUsuario.Click += new System.EventHandler(this.btnNovoUsuario_Click);
            // 
            // lblCaps
            // 
            this.lblCaps.AutoSize = true;
            this.lblCaps.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaps.ForeColor = System.Drawing.Color.Yellow;
            this.lblCaps.Location = new System.Drawing.Point(780, 265);
            this.lblCaps.Name = "lblCaps";
            this.lblCaps.Size = new System.Drawing.Size(87, 13);
            this.lblCaps.TabIndex = 11;
            this.lblCaps.Text = "CapsLock Ativada";
            // 
            // lblRelogio
            // 
            this.lblRelogio.AutoSize = true;
            this.lblRelogio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRelogio.Location = new System.Drawing.Point(783, 14);
            this.lblRelogio.Name = "lblRelogio";
            this.lblRelogio.Size = new System.Drawing.Size(0, 13);
            this.lblRelogio.TabIndex = 12;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // lblRelogio2
            // 
            this.lblRelogio2.AutoSize = true;
            this.lblRelogio2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRelogio2.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelogio2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRelogio2.Location = new System.Drawing.Point(742, 14);
            this.lblRelogio2.Name = "lblRelogio2";
            this.lblRelogio2.Size = new System.Drawing.Size(78, 15);
            this.lblRelogio2.TabIndex = 13;
            this.lblRelogio2.Text = "HH:mm:ss:fff";
            // 
            // btnAdm
            // 
            this.btnAdm.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdm.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdm.Location = new System.Drawing.Point(766, 421);
            this.btnAdm.Name = "btnAdm";
            this.btnAdm.Size = new System.Drawing.Size(54, 29);
            this.btnAdm.TabIndex = 14;
            this.btnAdm.Text = "Adm";
            this.btnAdm.UseVisualStyleBackColor = false;
            this.btnAdm.Click += new System.EventHandler(this.btnAdm_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(905, 535);
            this.Controls.Add(this.btnAdm);
            this.Controls.Add(this.lblRelogio2);
            this.Controls.Add(this.lblRelogio);
            this.Controls.Add(this.lblCaps);
            this.Controls.Add(this.btnNovoUsuario);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.usuarioTextBox);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.loginPictureBox);
            this.Controls.Add(this.idiomaBox);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "frmLogin";
            this.Text = "Login AirSystem";
            ((System.ComponentModel.ISupportInitialize)(this.loginPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox loginPictureBox;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNovoUsuario;
        private System.Windows.Forms.ComboBox idiomaBox;
        private System.Windows.Forms.Label lblCaps;
        private System.Windows.Forms.Label lblRelogio;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblRelogio2;
        private System.Windows.Forms.Button btnAdm;
    }
}


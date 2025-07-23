namespace HotelManagementSystem
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            PaneltopoLogin = new Panel();
            BtnSair = new Button();
            PanellateralLogin = new Panel();
            BtnLogin = new Button();
            CheckbxShowPas = new CheckBox();
            textBoxSenha = new TextBox();
            textBoxNomeUsuario = new TextBox();
            TextSenha = new Label();
            TxtUsuario = new Label();
            LinkTxtCriarconta = new LinkLabel();
            TextNaoeusuario = new Label();
            LogoLogin = new Label();
            pictureBoxprincipal = new PictureBox();
            PaneltopoLogin.SuspendLayout();
            PanellateralLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxprincipal).BeginInit();
            SuspendLayout();
            // 
            // PaneltopoLogin
            // 
            PaneltopoLogin.BackColor = Color.FromArgb(4, 99, 125);
            PaneltopoLogin.Controls.Add(BtnSair);
            PaneltopoLogin.Dock = DockStyle.Top;
            PaneltopoLogin.Location = new Point(0, 0);
            PaneltopoLogin.Margin = new Padding(4, 3, 4, 3);
            PaneltopoLogin.Name = "PaneltopoLogin";
            PaneltopoLogin.Size = new Size(1200, 95);
            PaneltopoLogin.TabIndex = 1;
            // 
            // BtnSair
            // 
            BtnSair.AccessibleRole = AccessibleRole.None;
            BtnSair.BackgroundImage = (Image)resources.GetObject("BtnSair.BackgroundImage");
            BtnSair.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSair.Dock = DockStyle.Right;
            BtnSair.FlatAppearance.BorderSize = 0;
            BtnSair.FlatStyle = FlatStyle.Flat;
            BtnSair.Font = new Font("Nirmala UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSair.ForeColor = Color.White;
            BtnSair.Location = new Point(1105, 0);
            BtnSair.Margin = new Padding(4, 3, 4, 3);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(95, 95);
            BtnSair.TabIndex = 5;
            BtnSair.UseVisualStyleBackColor = true;
            BtnSair.Click += BtnSair_Click;
            // 
            // PanellateralLogin
            // 
            PanellateralLogin.BackColor = Color.White;
            PanellateralLogin.Controls.Add(BtnLogin);
            PanellateralLogin.Controls.Add(CheckbxShowPas);
            PanellateralLogin.Controls.Add(textBoxSenha);
            PanellateralLogin.Controls.Add(textBoxNomeUsuario);
            PanellateralLogin.Controls.Add(TextSenha);
            PanellateralLogin.Controls.Add(TxtUsuario);
            PanellateralLogin.Controls.Add(LinkTxtCriarconta);
            PanellateralLogin.Controls.Add(TextNaoeusuario);
            PanellateralLogin.Controls.Add(LogoLogin);
            PanellateralLogin.Dock = DockStyle.Left;
            PanellateralLogin.Location = new Point(0, 95);
            PanellateralLogin.Margin = new Padding(4, 3, 4, 3);
            PanellateralLogin.Name = "PanellateralLogin";
            PanellateralLogin.Size = new Size(450, 705);
            PanellateralLogin.TabIndex = 2;
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = Color.FromArgb(4, 99, 125);
            BtnLogin.Cursor = Cursors.Hand;
            BtnLogin.FlatAppearance.BorderColor = Color.FromArgb(4, 99, 125);
            BtnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(4, 99, 125);
            BtnLogin.FlatStyle = FlatStyle.Flat;
            BtnLogin.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLogin.ForeColor = Color.White;
            BtnLogin.Location = new Point(90, 479);
            BtnLogin.Margin = new Padding(4, 3, 4, 3);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(250, 60);
            BtnLogin.TabIndex = 26;
            BtnLogin.Text = "LOGIN";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // CheckbxShowPas
            // 
            CheckbxShowPas.AutoSize = true;
            CheckbxShowPas.Cursor = Cursors.Hand;
            CheckbxShowPas.Font = new Font("Nirmala UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CheckbxShowPas.Location = new Point(91, 355);
            CheckbxShowPas.Margin = new Padding(4, 3, 4, 3);
            CheckbxShowPas.Name = "CheckbxShowPas";
            CheckbxShowPas.Size = new Size(111, 17);
            CheckbxShowPas.TabIndex = 25;
            CheckbxShowPas.Text = "Mostrar a Senha";
            CheckbxShowPas.UseVisualStyleBackColor = true;
            CheckbxShowPas.CheckedChanged += CheckbxShowPas_CheckedChanged;
            // 
            // textBoxSenha
            // 
            textBoxSenha.BackColor = Color.FromArgb(230, 231, 233);
            textBoxSenha.BorderStyle = BorderStyle.None;
            textBoxSenha.Cursor = Cursors.IBeam;
            textBoxSenha.Font = new Font("Nirmala UI", 9.75F);
            textBoxSenha.ForeColor = Color.Black;
            textBoxSenha.Location = new Point(90, 319);
            textBoxSenha.Margin = new Padding(4, 3, 4, 3);
            textBoxSenha.Multiline = true;
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.PasswordChar = '•';
            textBoxSenha.Size = new Size(250, 30);
            textBoxSenha.TabIndex = 11;
            // 
            // textBoxNomeUsuario
            // 
            textBoxNomeUsuario.Anchor = AnchorStyles.Left;
            textBoxNomeUsuario.BackColor = Color.FromArgb(230, 231, 233);
            textBoxNomeUsuario.BorderStyle = BorderStyle.None;
            textBoxNomeUsuario.Cursor = Cursors.IBeam;
            textBoxNomeUsuario.Font = new Font("Nirmala UI", 9.75F);
            textBoxNomeUsuario.ForeColor = Color.Black;
            textBoxNomeUsuario.Location = new Point(90, 220);
            textBoxNomeUsuario.Margin = new Padding(4, 3, 4, 3);
            textBoxNomeUsuario.Multiline = true;
            textBoxNomeUsuario.Name = "textBoxNomeUsuario";
            textBoxNomeUsuario.Size = new Size(250, 30);
            textBoxNomeUsuario.TabIndex = 10;
            // 
            // TextSenha
            // 
            TextSenha.AutoSize = true;
            TextSenha.BackColor = Color.FromArgb(67, 138, 158);
            TextSenha.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TextSenha.ForeColor = Color.White;
            TextSenha.Location = new Point(90, 295);
            TextSenha.Margin = new Padding(4, 0, 4, 0);
            TextSenha.Name = "TextSenha";
            TextSenha.Size = new Size(64, 21);
            TextSenha.TabIndex = 7;
            TextSenha.Text = "SENHA";
            // 
            // TxtUsuario
            // 
            TxtUsuario.AutoSize = true;
            TxtUsuario.BackColor = Color.FromArgb(67, 138, 158);
            TxtUsuario.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtUsuario.ForeColor = Color.White;
            TxtUsuario.Location = new Point(90, 196);
            TxtUsuario.Margin = new Padding(4, 0, 4, 0);
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.Size = new Size(159, 21);
            TxtUsuario.TabIndex = 6;
            TxtUsuario.Text = "NOME DE USUÁRIO";
            // 
            // LinkTxtCriarconta
            // 
            LinkTxtCriarconta.ActiveLinkColor = Color.DarkRed;
            LinkTxtCriarconta.AutoSize = true;
            LinkTxtCriarconta.Cursor = Cursors.Hand;
            LinkTxtCriarconta.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LinkTxtCriarconta.ForeColor = Color.DarkSlateGray;
            LinkTxtCriarconta.LinkColor = Color.FromArgb(4, 99, 125);
            LinkTxtCriarconta.Location = new Point(156, 625);
            LinkTxtCriarconta.Margin = new Padding(4, 0, 4, 0);
            LinkTxtCriarconta.Name = "LinkTxtCriarconta";
            LinkTxtCriarconta.Size = new Size(103, 21);
            LinkTxtCriarconta.TabIndex = 5;
            LinkTxtCriarconta.TabStop = true;
            LinkTxtCriarconta.Text = "clicando Aqui";
            LinkTxtCriarconta.VisitedLinkColor = Color.DarkSlateGray;
            LinkTxtCriarconta.LinkClicked += LinkTxtCriarconta_LinkClicked;
            // 
            // TextNaoeusuario
            // 
            TextNaoeusuario.AutoSize = true;
            TextNaoeusuario.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextNaoeusuario.Location = new Point(92, 605);
            TextNaoeusuario.Margin = new Padding(4, 0, 4, 0);
            TextNaoeusuario.Name = "TextNaoeusuario";
            TextNaoeusuario.Size = new Size(245, 21);
            TextNaoeusuario.TabIndex = 4;
            TextNaoeusuario.Text = "Não é um Usuário? Crie sua conta";
            // 
            // LogoLogin
            // 
            LogoLogin.AutoSize = true;
            LogoLogin.Font = new Font("Nirmala UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogoLogin.ForeColor = Color.FromArgb(4, 99, 125);
            LogoLogin.Location = new Point(150, 70);
            LogoLogin.Margin = new Padding(4, 0, 4, 0);
            LogoLogin.Name = "LogoLogin";
            LogoLogin.Size = new Size(135, 50);
            LogoLogin.TabIndex = 0;
            LogoLogin.Text = "LOGIN";
            // 
            // pictureBoxprincipal
            // 
            pictureBoxprincipal.BackgroundImage = (Image)resources.GetObject("pictureBoxprincipal.BackgroundImage");
            pictureBoxprincipal.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxprincipal.Location = new Point(450, 95);
            pictureBoxprincipal.Name = "pictureBoxprincipal";
            pictureBoxprincipal.Size = new Size(750, 705);
            pictureBoxprincipal.TabIndex = 7;
            pictureBoxprincipal.TabStop = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 800);
            Controls.Add(pictureBoxprincipal);
            Controls.Add(PanellateralLogin);
            Controls.Add(PaneltopoLogin);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            PaneltopoLogin.ResumeLayout(false);
            PanellateralLogin.ResumeLayout(false);
            PanellateralLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxprincipal).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PaneltopoLogin;
        private System.Windows.Forms.Panel PanellateralLogin;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.CheckBox CheckbxShowPas;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.TextBox textBoxNomeUsuario;
        private System.Windows.Forms.Label TextSenha;
        private System.Windows.Forms.Label TxtUsuario;
        private System.Windows.Forms.LinkLabel LinkTxtCriarconta;
        private System.Windows.Forms.Label TextNaoeusuario;
        private System.Windows.Forms.Label LogoLogin;
        private System.Windows.Forms.Button BtnSair;
        private PictureBox pictureBoxprincipal;
    }
}


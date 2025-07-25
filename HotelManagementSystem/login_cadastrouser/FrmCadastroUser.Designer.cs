namespace HotelManagementSystem.login_cadastrouser
{
    partial class FrmCadastroUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroUser));
            PaneltopoLogin = new Panel();
            BtnSair = new Button();
            Panellateralcadastro = new Panel();
            TextBoxConfirmarSenha = new TextBox();
            textconfirmar = new Label();
            Btncadastrar = new Button();
            CheckbxShowPas = new CheckBox();
            TextBoxSenha = new TextBox();
            textBoxNomeUsuario = new TextBox();
            TextSenha = new Label();
            TxtUsuario = new Label();
            LinkTxtentrarconta = new LinkLabel();
            Texteusuario = new Label();
            LogoLogin = new Label();
            pictureBoxprincipal = new PictureBox();
            PaneltopoLogin.SuspendLayout();
            Panellateralcadastro.SuspendLayout();
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
            PaneltopoLogin.TabIndex = 2;
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
            // Panellateralcadastro
            // 
            Panellateralcadastro.BackColor = Color.White;
            Panellateralcadastro.Controls.Add(TextBoxConfirmarSenha);
            Panellateralcadastro.Controls.Add(textconfirmar);
            Panellateralcadastro.Controls.Add(Btncadastrar);
            Panellateralcadastro.Controls.Add(CheckbxShowPas);
            Panellateralcadastro.Controls.Add(TextBoxSenha);
            Panellateralcadastro.Controls.Add(textBoxNomeUsuario);
            Panellateralcadastro.Controls.Add(TextSenha);
            Panellateralcadastro.Controls.Add(TxtUsuario);
            Panellateralcadastro.Controls.Add(LinkTxtentrarconta);
            Panellateralcadastro.Controls.Add(Texteusuario);
            Panellateralcadastro.Controls.Add(LogoLogin);
            Panellateralcadastro.Dock = DockStyle.Left;
            Panellateralcadastro.Location = new Point(0, 95);
            Panellateralcadastro.Margin = new Padding(4, 3, 4, 3);
            Panellateralcadastro.Name = "Panellateralcadastro";
            Panellateralcadastro.Size = new Size(450, 705);
            Panellateralcadastro.TabIndex = 3;
            // 
            // TextBoxConfirmarSenha
            // 
            TextBoxConfirmarSenha.BackColor = Color.FromArgb(230, 231, 233);
            TextBoxConfirmarSenha.BorderStyle = BorderStyle.None;
            TextBoxConfirmarSenha.Cursor = Cursors.IBeam;
            TextBoxConfirmarSenha.Font = new Font("Nirmala UI", 9.75F);
            TextBoxConfirmarSenha.ForeColor = Color.Black;
            TextBoxConfirmarSenha.Location = new Point(98, 393);
            TextBoxConfirmarSenha.Margin = new Padding(4, 3, 4, 3);
            TextBoxConfirmarSenha.MaxLength = 30;
            TextBoxConfirmarSenha.Multiline = true;
            TextBoxConfirmarSenha.Name = "TextBoxConfirmarSenha";
            TextBoxConfirmarSenha.PasswordChar = '•';
            TextBoxConfirmarSenha.Size = new Size(250, 30);
            TextBoxConfirmarSenha.TabIndex = 37;
            // 
            // textconfirmar
            // 
            textconfirmar.AutoSize = true;
            textconfirmar.BackColor = Color.FromArgb(67, 138, 158);
            textconfirmar.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textconfirmar.ForeColor = Color.White;
            textconfirmar.Location = new Point(98, 369);
            textconfirmar.Margin = new Padding(4, 0, 4, 0);
            textconfirmar.Name = "textconfirmar";
            textconfirmar.Size = new Size(162, 21);
            textconfirmar.TabIndex = 36;
            textconfirmar.Text = "CONFIRMAR SENHA";
            // 
            // Btncadastrar
            // 
            Btncadastrar.BackColor = Color.FromArgb(4, 99, 125);
            Btncadastrar.Cursor = Cursors.Hand;
            Btncadastrar.FlatAppearance.BorderColor = Color.FromArgb(4, 99, 125);
            Btncadastrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(4, 99, 125);
            Btncadastrar.FlatStyle = FlatStyle.Flat;
            Btncadastrar.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btncadastrar.ForeColor = Color.White;
            Btncadastrar.Location = new Point(98, 479);
            Btncadastrar.Margin = new Padding(4, 3, 4, 3);
            Btncadastrar.Name = "Btncadastrar";
            Btncadastrar.Size = new Size(250, 60);
            Btncadastrar.TabIndex = 35;
            Btncadastrar.Text = "CADASTRAR";
            Btncadastrar.UseVisualStyleBackColor = false;
            Btncadastrar.Click += Btncadastrar_Click;
            // 
            // CheckbxShowPas
            // 
            CheckbxShowPas.AutoSize = true;
            CheckbxShowPas.Cursor = Cursors.Hand;
            CheckbxShowPas.Font = new Font("Nirmala UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CheckbxShowPas.Location = new Point(98, 429);
            CheckbxShowPas.Margin = new Padding(4, 3, 4, 3);
            CheckbxShowPas.Name = "CheckbxShowPas";
            CheckbxShowPas.Size = new Size(111, 17);
            CheckbxShowPas.TabIndex = 34;
            CheckbxShowPas.Text = "Mostrar a Senha";
            CheckbxShowPas.UseVisualStyleBackColor = true;
            CheckbxShowPas.CheckedChanged += CheckbxShowPas_CheckedChanged;
            // 
            // TextBoxSenha
            // 
            TextBoxSenha.BackColor = Color.FromArgb(230, 231, 233);
            TextBoxSenha.BorderStyle = BorderStyle.None;
            TextBoxSenha.Cursor = Cursors.IBeam;
            TextBoxSenha.Font = new Font("Nirmala UI", 9.75F);
            TextBoxSenha.ForeColor = Color.Black;
            TextBoxSenha.Location = new Point(98, 308);
            TextBoxSenha.Margin = new Padding(4, 3, 4, 3);
            TextBoxSenha.MaxLength = 30;
            TextBoxSenha.Multiline = true;
            TextBoxSenha.Name = "TextBoxSenha";
            TextBoxSenha.PasswordChar = '•';
            TextBoxSenha.Size = new Size(250, 30);
            TextBoxSenha.TabIndex = 33;
            // 
            // textBoxNomeUsuario
            // 
            textBoxNomeUsuario.Anchor = AnchorStyles.Left;
            textBoxNomeUsuario.BackColor = Color.FromArgb(230, 231, 233);
            textBoxNomeUsuario.BorderStyle = BorderStyle.None;
            textBoxNomeUsuario.Cursor = Cursors.IBeam;
            textBoxNomeUsuario.Font = new Font("Nirmala UI", 9.75F);
            textBoxNomeUsuario.ForeColor = Color.Black;
            textBoxNomeUsuario.Location = new Point(98, 220);
            textBoxNomeUsuario.Margin = new Padding(4, 3, 4, 3);
            textBoxNomeUsuario.MaxLength = 30;
            textBoxNomeUsuario.Multiline = true;
            textBoxNomeUsuario.Name = "textBoxNomeUsuario";
            textBoxNomeUsuario.Size = new Size(250, 30);
            textBoxNomeUsuario.TabIndex = 32;
            // 
            // TextSenha
            // 
            TextSenha.AutoSize = true;
            TextSenha.BackColor = Color.FromArgb(67, 138, 158);
            TextSenha.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TextSenha.ForeColor = Color.White;
            TextSenha.Location = new Point(98, 284);
            TextSenha.Margin = new Padding(4, 0, 4, 0);
            TextSenha.Name = "TextSenha";
            TextSenha.Size = new Size(64, 21);
            TextSenha.TabIndex = 31;
            TextSenha.Text = "SENHA";
            // 
            // TxtUsuario
            // 
            TxtUsuario.AutoSize = true;
            TxtUsuario.BackColor = Color.FromArgb(67, 138, 158);
            TxtUsuario.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtUsuario.ForeColor = Color.White;
            TxtUsuario.Location = new Point(98, 196);
            TxtUsuario.Margin = new Padding(4, 0, 4, 0);
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.Size = new Size(159, 21);
            TxtUsuario.TabIndex = 30;
            TxtUsuario.Text = "NOME DE USUÁRIO";
            // 
            // LinkTxtentrarconta
            // 
            LinkTxtentrarconta.ActiveLinkColor = Color.DarkRed;
            LinkTxtentrarconta.AutoSize = true;
            LinkTxtentrarconta.Cursor = Cursors.Hand;
            LinkTxtentrarconta.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LinkTxtentrarconta.ForeColor = Color.DarkSlateGray;
            LinkTxtentrarconta.LinkColor = Color.FromArgb(4, 99, 125);
            LinkTxtentrarconta.Location = new Point(158, 628);
            LinkTxtentrarconta.Margin = new Padding(4, 0, 4, 0);
            LinkTxtentrarconta.Name = "LinkTxtentrarconta";
            LinkTxtentrarconta.Size = new Size(106, 21);
            LinkTxtentrarconta.TabIndex = 29;
            LinkTxtentrarconta.TabStop = true;
            LinkTxtentrarconta.Text = "Clicando Aqui";
            LinkTxtentrarconta.VisitedLinkColor = Color.DarkSlateGray;
            LinkTxtentrarconta.LinkClicked += LinkTxtentrarconta_LinkClicked;
            // 
            // Texteusuario
            // 
            Texteusuario.AutoSize = true;
            Texteusuario.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Texteusuario.Location = new Point(74, 607);
            Texteusuario.Margin = new Padding(4, 0, 4, 0);
            Texteusuario.Name = "Texteusuario";
            Texteusuario.Size = new Size(294, 21);
            Texteusuario.TabIndex = 28;
            Texteusuario.Text = "Você já tem Cadastro? Entre na sua conta";
            // 
            // LogoLogin
            // 
            LogoLogin.AutoSize = true;
            LogoLogin.Font = new Font("Nirmala UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogoLogin.ForeColor = Color.FromArgb(4, 99, 125);
            LogoLogin.Location = new Point(116, 73);
            LogoLogin.Margin = new Padding(4, 0, 4, 0);
            LogoLogin.Name = "LogoLogin";
            LogoLogin.Size = new Size(218, 50);
            LogoLogin.TabIndex = 27;
            LogoLogin.Text = "CADASTRO";
            // 
            // pictureBoxprincipal
            // 
            pictureBoxprincipal.BackgroundImage = (Image)resources.GetObject("pictureBoxprincipal.BackgroundImage");
            pictureBoxprincipal.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxprincipal.Location = new Point(449, 95);
            pictureBoxprincipal.Name = "pictureBoxprincipal";
            pictureBoxprincipal.Size = new Size(751, 705);
            pictureBoxprincipal.TabIndex = 8;
            pictureBoxprincipal.TabStop = false;
            // 
            // FrmCadastroUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 800);
            Controls.Add(pictureBoxprincipal);
            Controls.Add(Panellateralcadastro);
            Controls.Add(PaneltopoLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCadastroUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCadastroUser";
            PaneltopoLogin.ResumeLayout(false);
            Panellateralcadastro.ResumeLayout(false);
            Panellateralcadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxprincipal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PaneltopoLogin;
        private Button BtnSair;
        private Panel Panellateralcadastro;
        private PictureBox pictureBoxprincipal;
        private Button Btncadastrar;
        private CheckBox CheckbxShowPas;
        private TextBox TextBoxSenha;
        private TextBox textBoxNomeUsuario;
        private Label TextSenha;
        private Label TxtUsuario;
        private LinkLabel LinkTxtentrarconta;
        private Label Texteusuario;
        private Label LogoLogin;
        private TextBox TextBoxConfirmarSenha;
        private Label textconfirmar;
    }
}
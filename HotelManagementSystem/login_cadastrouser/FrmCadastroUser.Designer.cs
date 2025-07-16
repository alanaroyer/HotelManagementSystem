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
            PanellateralLogin = new Panel();
            textBox1 = new TextBox();
            BtnLogin = new Button();
            CheckbxShowPas = new CheckBox();
            textBoxSenha = new TextBox();
            TextSenha = new Label();
            TxtUsuario = new Label();
            LinkTxtCriarconta = new LinkLabel();
            TextNaoeusuario = new Label();
            Logocadastro = new Label();
            pictureBoxprincipal = new PictureBox();
            txtbxconfirmarsenha = new TextBox();
            Txtconfirmarsenha = new Label();
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
            PaneltopoLogin.Size = new Size(1200, 92);
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
            BtnSair.Location = new Point(1115, 0);
            BtnSair.Margin = new Padding(4, 3, 4, 3);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(85, 92);
            BtnSair.TabIndex = 5;
            BtnSair.UseVisualStyleBackColor = true;
            BtnSair.Click += BtnSair_Click;
            // 
            // PanellateralLogin
            // 
            PanellateralLogin.BackColor = Color.White;
            PanellateralLogin.Controls.Add(txtbxconfirmarsenha);
            PanellateralLogin.Controls.Add(Txtconfirmarsenha);
            PanellateralLogin.Controls.Add(textBox1);
            PanellateralLogin.Controls.Add(BtnLogin);
            PanellateralLogin.Controls.Add(CheckbxShowPas);
            PanellateralLogin.Controls.Add(textBoxSenha);
            PanellateralLogin.Controls.Add(TextSenha);
            PanellateralLogin.Controls.Add(TxtUsuario);
            PanellateralLogin.Controls.Add(LinkTxtCriarconta);
            PanellateralLogin.Controls.Add(TextNaoeusuario);
            PanellateralLogin.Controls.Add(Logocadastro);
            PanellateralLogin.Dock = DockStyle.Left;
            PanellateralLogin.Location = new Point(0, 92);
            PanellateralLogin.Margin = new Padding(4, 3, 4, 3);
            PanellateralLogin.Name = "PanellateralLogin";
            PanellateralLogin.Size = new Size(450, 708);
            PanellateralLogin.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left;
            textBox1.BackColor = Color.FromArgb(230, 231, 233);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.WindowText;
            textBox1.Location = new Point(94, 151);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(255, 35);
            textBox1.TabIndex = 27;
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
            BtnLogin.Location = new Point(105, 417);
            BtnLogin.Margin = new Padding(4, 3, 4, 3);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(245, 60);
            BtnLogin.TabIndex = 26;
            BtnLogin.Text = "LOGIN";
            BtnLogin.UseVisualStyleBackColor = false;
            // 
            // CheckbxShowPas
            // 
            CheckbxShowPas.AutoSize = true;
            CheckbxShowPas.Cursor = Cursors.Hand;
            CheckbxShowPas.FlatStyle = FlatStyle.Flat;
            CheckbxShowPas.Font = new Font("Nirmala UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CheckbxShowPas.Location = new Point(94, 376);
            CheckbxShowPas.Margin = new Padding(4, 3, 4, 3);
            CheckbxShowPas.Name = "CheckbxShowPas";
            CheckbxShowPas.Size = new Size(108, 17);
            CheckbxShowPas.TabIndex = 25;
            CheckbxShowPas.Text = "Mostrar a Senha";
            CheckbxShowPas.UseVisualStyleBackColor = true;
            // 
            // textBoxSenha
            // 
            textBoxSenha.BackColor = Color.FromArgb(230, 231, 233);
            textBoxSenha.BorderStyle = BorderStyle.None;
            textBoxSenha.Cursor = Cursors.IBeam;
            textBoxSenha.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSenha.ForeColor = SystemColors.WindowText;
            textBoxSenha.Location = new Point(94, 235);
            textBoxSenha.Margin = new Padding(4, 3, 4, 3);
            textBoxSenha.Multiline = true;
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.PasswordChar = '•';
            textBoxSenha.Size = new Size(255, 35);
            textBoxSenha.TabIndex = 11;
            // 
            // TextSenha
            // 
            TextSenha.AutoSize = true;
            TextSenha.BackColor = SystemColors.Menu;
            TextSenha.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TextSenha.ForeColor = Color.Black;
            TextSenha.Location = new Point(94, 212);
            TextSenha.Margin = new Padding(4, 0, 4, 0);
            TextSenha.Name = "TextSenha";
            TextSenha.Size = new Size(64, 21);
            TextSenha.TabIndex = 7;
            TextSenha.Text = "SENHA";
            // 
            // TxtUsuario
            // 
            TxtUsuario.AutoSize = true;
            TxtUsuario.BackColor = SystemColors.Menu;
            TxtUsuario.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtUsuario.ForeColor = Color.Black;
            TxtUsuario.Location = new Point(96, 127);
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
            LinkTxtCriarconta.Location = new Point(168, 582);
            LinkTxtCriarconta.Margin = new Padding(4, 0, 4, 0);
            LinkTxtCriarconta.Name = "LinkTxtCriarconta";
            LinkTxtCriarconta.Size = new Size(103, 21);
            LinkTxtCriarconta.TabIndex = 5;
            LinkTxtCriarconta.TabStop = true;
            LinkTxtCriarconta.Text = "clicando Aqui";
            LinkTxtCriarconta.VisitedLinkColor = Color.DarkSlateGray;
            // 
            // TextNaoeusuario
            // 
            TextNaoeusuario.AutoSize = true;
            TextNaoeusuario.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextNaoeusuario.Location = new Point(104, 561);
            TextNaoeusuario.Margin = new Padding(4, 0, 4, 0);
            TextNaoeusuario.Name = "TextNaoeusuario";
            TextNaoeusuario.Size = new Size(265, 21);
            TextNaoeusuario.TabIndex = 4;
            TextNaoeusuario.Text = "Você é um Usuário? Faça o seu Login";
            // 
            // Logocadastro
            // 
            Logocadastro.AutoSize = true;
            Logocadastro.Font = new Font("Nirmala UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Logocadastro.ForeColor = Color.FromArgb(4, 99, 125);
            Logocadastro.Location = new Point(117, 67);
            Logocadastro.Margin = new Padding(4, 0, 4, 0);
            Logocadastro.Name = "Logocadastro";
            Logocadastro.Size = new Size(218, 50);
            Logocadastro.TabIndex = 0;
            Logocadastro.Text = "CADASTRO";
            // 
            // pictureBoxprincipal
            // 
            pictureBoxprincipal.BackgroundImage = (Image)resources.GetObject("pictureBoxprincipal.BackgroundImage");
            pictureBoxprincipal.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxprincipal.Location = new Point(449, 92);
            pictureBoxprincipal.Name = "pictureBoxprincipal";
            pictureBoxprincipal.Size = new Size(751, 705);
            pictureBoxprincipal.TabIndex = 8;
            pictureBoxprincipal.TabStop = false;
            // 
            // txtbxconfirmarsenha
            // 
            txtbxconfirmarsenha.BackColor = Color.FromArgb(230, 231, 233);
            txtbxconfirmarsenha.BorderStyle = BorderStyle.None;
            txtbxconfirmarsenha.Cursor = Cursors.IBeam;
            txtbxconfirmarsenha.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxconfirmarsenha.ForeColor = SystemColors.WindowText;
            txtbxconfirmarsenha.Location = new Point(96, 314);
            txtbxconfirmarsenha.Margin = new Padding(4, 3, 4, 3);
            txtbxconfirmarsenha.Multiline = true;
            txtbxconfirmarsenha.Name = "txtbxconfirmarsenha";
            txtbxconfirmarsenha.PasswordChar = '•';
            txtbxconfirmarsenha.Size = new Size(255, 35);
            txtbxconfirmarsenha.TabIndex = 29;
            // 
            // Txtconfirmarsenha
            // 
            Txtconfirmarsenha.AutoSize = true;
            Txtconfirmarsenha.BackColor = SystemColors.Menu;
            Txtconfirmarsenha.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Txtconfirmarsenha.ForeColor = Color.Black;
            Txtconfirmarsenha.Location = new Point(96, 291);
            Txtconfirmarsenha.Margin = new Padding(4, 0, 4, 0);
            Txtconfirmarsenha.Name = "Txtconfirmarsenha";
            Txtconfirmarsenha.Size = new Size(162, 21);
            Txtconfirmarsenha.TabIndex = 28;
            Txtconfirmarsenha.Text = "CONFIRMAR SENHA";
            // 
            // FrmCadastroUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 800);
            Controls.Add(pictureBoxprincipal);
            Controls.Add(PanellateralLogin);
            Controls.Add(PaneltopoLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCadastroUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCadastroUser";
            PaneltopoLogin.ResumeLayout(false);
            PanellateralLogin.ResumeLayout(false);
            PanellateralLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxprincipal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PaneltopoLogin;
        private Button BtnSair;
        private Panel PanellateralLogin;
        private Button BtnLogin;
        private CheckBox CheckbxShowPas;
        private TextBox textBoxSenha;
        private Label TextSenha;
        private Label TxtUsuario;
        private LinkLabel LinkTxtCriarconta;
        private Label TextNaoeusuario;
        private Label Logocadastro;
        private TextBox textBox1;
        private PictureBox pictureBoxprincipal;
        private TextBox txtbxconfirmarsenha;
        private Label Txtconfirmarsenha;
    }
}
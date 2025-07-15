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
            pictureBox2 = new PictureBox();
            BtnSair = new Button();
            PanellateralLogin = new Panel();
            PicSenha = new PictureBox();
            PicUser = new PictureBox();
            BtnLogin = new Button();
            CheckbxShowPas = new CheckBox();
            textBoxSenha = new TextBox();
            textBoxNomeUsuario = new TextBox();
            TextSenha = new Label();
            TxtUsuario = new Label();
            LinkTxtCriarconta = new LinkLabel();
            TextNaoeusuario = new Label();
            LogoLogin = new Label();
            pictureBox1 = new PictureBox();
            PaneltopoLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            PanellateralLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicSenha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PaneltopoLogin
            // 
            PaneltopoLogin.BackColor = Color.FromArgb(4, 99, 125);
            PaneltopoLogin.Controls.Add(pictureBox2);
            PaneltopoLogin.Controls.Add(BtnSair);
            PaneltopoLogin.Dock = DockStyle.Top;
            PaneltopoLogin.Location = new Point(0, 0);
            PaneltopoLogin.Margin = new Padding(4, 3, 4, 3);
            PaneltopoLogin.Name = "PaneltopoLogin";
            PaneltopoLogin.Size = new Size(1200, 92);
            PaneltopoLogin.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(14, 14);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(91, 72);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
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
            PanellateralLogin.Controls.Add(PicSenha);
            PanellateralLogin.Controls.Add(PicUser);
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
            PanellateralLogin.Location = new Point(0, 92);
            PanellateralLogin.Margin = new Padding(4, 3, 4, 3);
            PanellateralLogin.Name = "PanellateralLogin";
            PanellateralLogin.Size = new Size(467, 708);
            PanellateralLogin.TabIndex = 2;
            // 
            // PicSenha
            // 
            PicSenha.BackgroundImage = (Image)resources.GetObject("PicSenha.BackgroundImage");
            PicSenha.BackgroundImageLayout = ImageLayout.Zoom;
            PicSenha.Location = new Point(61, 307);
            PicSenha.Margin = new Padding(4, 3, 4, 3);
            PicSenha.Name = "PicSenha";
            PicSenha.Size = new Size(51, 46);
            PicSenha.TabIndex = 28;
            PicSenha.TabStop = false;
            // 
            // PicUser
            // 
            PicUser.BackgroundImage = (Image)resources.GetObject("PicUser.BackgroundImage");
            PicUser.BackgroundImageLayout = ImageLayout.Zoom;
            PicUser.Location = new Point(61, 208);
            PicUser.Margin = new Padding(4, 3, 4, 3);
            PicUser.Name = "PicUser";
            PicUser.Size = new Size(51, 46);
            PicUser.TabIndex = 27;
            PicUser.TabStop = false;
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
            BtnLogin.Location = new Point(140, 442);
            BtnLogin.Margin = new Padding(4, 3, 4, 3);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(175, 58);
            BtnLogin.TabIndex = 26;
            BtnLogin.Text = "LOGIN";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // CheckbxShowPas
            // 
            CheckbxShowPas.AutoSize = true;
            CheckbxShowPas.Cursor = Cursors.Hand;
            CheckbxShowPas.FlatStyle = FlatStyle.Flat;
            CheckbxShowPas.Font = new Font("Nirmala UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CheckbxShowPas.Location = new Point(241, 360);
            CheckbxShowPas.Margin = new Padding(4, 3, 4, 3);
            CheckbxShowPas.Name = "CheckbxShowPas";
            CheckbxShowPas.Size = new Size(108, 17);
            CheckbxShowPas.TabIndex = 25;
            CheckbxShowPas.Text = "Mostrar a Senha";
            CheckbxShowPas.UseVisualStyleBackColor = true;
            CheckbxShowPas.CheckedChanged += CheckbxShowPas_CheckedChanged;
            // 
            // textBoxSenha
            // 
            textBoxSenha.BackColor = Color.FromArgb(230, 231, 233);
            textBoxSenha.BorderStyle = BorderStyle.None;
            textBoxSenha.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSenha.ForeColor = SystemColors.WindowText;
            textBoxSenha.Location = new Point(115, 324);
            textBoxSenha.Margin = new Padding(4, 3, 4, 3);
            textBoxSenha.Multiline = true;
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.PasswordChar = '•';
            textBoxSenha.Size = new Size(257, 29);
            textBoxSenha.TabIndex = 11;
            // 
            // textBoxNomeUsuario
            // 
            textBoxNomeUsuario.BackColor = Color.FromArgb(230, 231, 233);
            textBoxNomeUsuario.BorderStyle = BorderStyle.None;
            textBoxNomeUsuario.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNomeUsuario.ForeColor = SystemColors.WindowText;
            textBoxNomeUsuario.Location = new Point(115, 225);
            textBoxNomeUsuario.Margin = new Padding(4, 3, 4, 3);
            textBoxNomeUsuario.Multiline = true;
            textBoxNomeUsuario.Name = "textBoxNomeUsuario";
            textBoxNomeUsuario.Size = new Size(255, 29);
            textBoxNomeUsuario.TabIndex = 10;
            // 
            // TextSenha
            // 
            TextSenha.AutoSize = true;
            TextSenha.BackColor = SystemColors.Menu;
            TextSenha.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TextSenha.ForeColor = Color.Black;
            TextSenha.Location = new Point(119, 290);
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
            TxtUsuario.Location = new Point(119, 190);
            TxtUsuario.Margin = new Padding(4, 0, 4, 0);
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.Size = new Size(81, 21);
            TxtUsuario.TabIndex = 6;
            TxtUsuario.Text = "USUÁRIO";
            // 
            // LinkTxtCriarconta
            // 
            LinkTxtCriarconta.ActiveLinkColor = Color.DarkRed;
            LinkTxtCriarconta.AutoSize = true;
            LinkTxtCriarconta.Cursor = Cursors.Hand;
            LinkTxtCriarconta.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LinkTxtCriarconta.ForeColor = Color.DarkSlateGray;
            LinkTxtCriarconta.LinkColor = Color.FromArgb(4, 99, 125);
            LinkTxtCriarconta.Location = new Point(164, 651);
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
            TextNaoeusuario.Location = new Point(95, 610);
            TextNaoeusuario.Margin = new Padding(4, 0, 4, 0);
            TextNaoeusuario.Name = "TextNaoeusuario";
            TextNaoeusuario.Size = new Size(245, 21);
            TextNaoeusuario.TabIndex = 4;
            TextNaoeusuario.Text = "Não é um Usuário? Crie sua conta";
            // 
            // LogoLogin
            // 
            LogoLogin.AutoSize = true;
            LogoLogin.Font = new Font("Nirmala UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogoLogin.ForeColor = Color.FromArgb(4, 99, 125);
            LogoLogin.Location = new Point(152, 87);
            LogoLogin.Margin = new Padding(4, 0, 4, 0);
            LogoLogin.Name = "LogoLogin";
            LogoLogin.Size = new Size(128, 47);
            LogoLogin.TabIndex = 0;
            LogoLogin.Text = "LOGIN";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(463, 92);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1130, 794);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 800);
            Controls.Add(pictureBox1);
            Controls.Add(PanellateralLogin);
            Controls.Add(PaneltopoLogin);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            PaneltopoLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            PanellateralLogin.ResumeLayout(false);
            PanellateralLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicSenha).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private System.Windows.Forms.PictureBox PicSenha;
        private System.Windows.Forms.PictureBox PicUser;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


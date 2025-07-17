namespace HotelManagementSystem.reservas
{
    partial class FrmReservas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReservas));
            Paneltop = new Panel();
            BtnSair = new Button();
            txtreservas = new Label();
            labelquarto = new Label();
            cbxquarto = new ComboBox();
            cbxmes = new ComboBox();
            labelmes = new Label();
            cbxano = new ComboBox();
            labelano = new Label();
            labelvalordiaria = new Label();
            tbxvalordiaria = new TextBox();
            tbxdias = new TextBox();
            labeldias = new Label();
            tbxhospede = new TextBox();
            labelnomehospede = new Label();
            labelfuncionario = new Label();
            cbxfuncionario = new ComboBox();
            Paneltop.SuspendLayout();
            SuspendLayout();
            // 
            // Paneltop
            // 
            Paneltop.BackColor = Color.FromArgb(4, 99, 125);
            Paneltop.Controls.Add(txtreservas);
            Paneltop.Controls.Add(BtnSair);
            Paneltop.Dock = DockStyle.Top;
            Paneltop.Location = new Point(0, 0);
            Paneltop.Margin = new Padding(4, 3, 4, 3);
            Paneltop.Name = "Paneltop";
            Paneltop.Size = new Size(1200, 95);
            Paneltop.TabIndex = 2;
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
            BtnSair.Size = new Size(85, 95);
            BtnSair.TabIndex = 5;
            BtnSair.UseVisualStyleBackColor = true;
            BtnSair.Click += BtnSair_Click;
            // 
            // txtreservas
            // 
            txtreservas.AutoSize = true;
            txtreservas.BackColor = SystemColors.ButtonFace;
            txtreservas.Font = new Font("Nirmala UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtreservas.ForeColor = Color.FromArgb(4, 99, 125);
            txtreservas.Location = new Point(17, 15);
            txtreservas.Margin = new Padding(4, 0, 4, 0);
            txtreservas.Name = "txtreservas";
            txtreservas.Size = new Size(224, 65);
            txtreservas.TabIndex = 6;
            txtreservas.Text = "Reservas";
            // 
            // labelquarto
            // 
            labelquarto.AutoSize = true;
            labelquarto.BackColor = Color.FromArgb(118, 177, 206);
            labelquarto.FlatStyle = FlatStyle.Flat;
            labelquarto.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelquarto.ForeColor = SystemColors.ButtonFace;
            labelquarto.Location = new Point(34, 123);
            labelquarto.Name = "labelquarto";
            labelquarto.Size = new Size(76, 25);
            labelquarto.TabIndex = 7;
            labelquarto.Text = "Quarto";
            // 
            // cbxquarto
            // 
            cbxquarto.FormattingEnabled = true;
            cbxquarto.Location = new Point(112, 124);
            cbxquarto.Name = "cbxquarto";
            cbxquarto.Size = new Size(65, 23);
            cbxquarto.TabIndex = 8;
            // 
            // cbxmes
            // 
            cbxmes.FormattingEnabled = true;
            cbxmes.Location = new Point(249, 124);
            cbxmes.Name = "cbxmes";
            cbxmes.Size = new Size(55, 23);
            cbxmes.TabIndex = 10;
            // 
            // labelmes
            // 
            labelmes.AutoSize = true;
            labelmes.BackColor = Color.FromArgb(118, 177, 206);
            labelmes.FlatStyle = FlatStyle.Flat;
            labelmes.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelmes.ForeColor = SystemColors.ButtonFace;
            labelmes.Location = new Point(199, 122);
            labelmes.Name = "labelmes";
            labelmes.Size = new Size(48, 25);
            labelmes.TabIndex = 9;
            labelmes.Text = "Mês";
            // 
            // cbxano
            // 
            cbxano.FormattingEnabled = true;
            cbxano.Location = new Point(249, 169);
            cbxano.Name = "cbxano";
            cbxano.Size = new Size(62, 23);
            cbxano.TabIndex = 12;
            // 
            // labelano
            // 
            labelano.AutoSize = true;
            labelano.BackColor = Color.FromArgb(118, 177, 206);
            labelano.FlatStyle = FlatStyle.Flat;
            labelano.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelano.ForeColor = SystemColors.ButtonFace;
            labelano.Location = new Point(198, 168);
            labelano.Name = "labelano";
            labelano.Size = new Size(49, 25);
            labelano.TabIndex = 11;
            labelano.Text = "Ano";
            // 
            // labelvalordiaria
            // 
            labelvalordiaria.AutoSize = true;
            labelvalordiaria.BackColor = Color.FromArgb(118, 177, 206);
            labelvalordiaria.FlatStyle = FlatStyle.Flat;
            labelvalordiaria.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelvalordiaria.ForeColor = SystemColors.ButtonFace;
            labelvalordiaria.Location = new Point(379, 124);
            labelvalordiaria.Name = "labelvalordiaria";
            labelvalordiaria.Size = new Size(143, 25);
            labelvalordiaria.TabIndex = 13;
            labelvalordiaria.Text = "Valor da Diária";
            // 
            // tbxvalordiaria
            // 
            tbxvalordiaria.Location = new Point(524, 125);
            tbxvalordiaria.Name = "tbxvalordiaria";
            tbxvalordiaria.Size = new Size(100, 23);
            tbxvalordiaria.TabIndex = 14;
            // 
            // tbxdias
            // 
            tbxdias.Location = new Point(430, 170);
            tbxdias.Name = "tbxdias";
            tbxdias.Size = new Size(100, 23);
            tbxdias.TabIndex = 16;
            // 
            // labeldias
            // 
            labeldias.AutoSize = true;
            labeldias.BackColor = Color.FromArgb(118, 177, 206);
            labeldias.FlatStyle = FlatStyle.Flat;
            labeldias.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labeldias.ForeColor = SystemColors.ButtonFace;
            labeldias.Location = new Point(379, 169);
            labeldias.Name = "labeldias";
            labeldias.Size = new Size(49, 25);
            labeldias.TabIndex = 15;
            labeldias.Text = "Dias";
            // 
            // tbxhospede
            // 
            tbxhospede.Location = new Point(838, 126);
            tbxhospede.Name = "tbxhospede";
            tbxhospede.Size = new Size(216, 23);
            tbxhospede.TabIndex = 18;
            // 
            // labelnomehospede
            // 
            labelnomehospede.AutoSize = true;
            labelnomehospede.BackColor = Color.FromArgb(118, 177, 206);
            labelnomehospede.FlatStyle = FlatStyle.Flat;
            labelnomehospede.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelnomehospede.ForeColor = SystemColors.ButtonFace;
            labelnomehospede.Location = new Point(653, 125);
            labelnomehospede.Name = "labelnomehospede";
            labelnomehospede.Size = new Size(179, 25);
            labelnomehospede.TabIndex = 17;
            labelnomehospede.Text = "Nome do Hóspede";
            // 
            // labelfuncionario
            // 
            labelfuncionario.AutoSize = true;
            labelfuncionario.BackColor = Color.FromArgb(118, 177, 206);
            labelfuncionario.FlatStyle = FlatStyle.Flat;
            labelfuncionario.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelfuncionario.ForeColor = SystemColors.ButtonFace;
            labelfuncionario.Location = new Point(564, 167);
            labelfuncionario.Name = "labelfuncionario";
            labelfuncionario.Size = new Size(143, 25);
            labelfuncionario.TabIndex = 19;
            labelfuncionario.Text = "Funcionário(a)";
            // 
            // cbxfuncionario
            // 
            cbxfuncionario.FormattingEnabled = true;
            cbxfuncionario.Location = new Point(713, 167);
            cbxfuncionario.Name = "cbxfuncionario";
            cbxfuncionario.Size = new Size(85, 23);
            cbxfuncionario.TabIndex = 22;
            // 
            // FrmReservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1200, 800);
            Controls.Add(cbxfuncionario);
            Controls.Add(labelfuncionario);
            Controls.Add(tbxhospede);
            Controls.Add(labelnomehospede);
            Controls.Add(tbxdias);
            Controls.Add(labeldias);
            Controls.Add(tbxvalordiaria);
            Controls.Add(labelvalordiaria);
            Controls.Add(cbxano);
            Controls.Add(labelano);
            Controls.Add(cbxmes);
            Controls.Add(labelmes);
            Controls.Add(cbxquarto);
            Controls.Add(labelquarto);
            Controls.Add(Paneltop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmReservas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmReservas";
            Paneltop.ResumeLayout(false);
            Paneltop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Paneltop;
        private Button BtnSair;
        private Label txtreservas;
        private Label labelquarto;
        private ComboBox cbxquarto;
        private ComboBox cbxmes;
        private Label labelmes;
        private ComboBox cbxano;
        private Label labelano;
        private Label labelvalordiaria;
        private TextBox tbxvalordiaria;
        private TextBox tbxdias;
        private Label labeldias;
        private TextBox tbxhospede;
        private Label labelnomehospede;
        private Label labelfuncionario;
        private ComboBox cbxfuncionario;
    }
}
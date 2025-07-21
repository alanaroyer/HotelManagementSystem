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
            btnconsultar = new Button();
            Btnreservar = new Button();
            txtreservas = new Label();
            BtnSair = new Button();
            labelquarto = new Label();
            cbquarto = new ComboBox();
            labelvalordiaria = new Label();
            tbxvalordiaria = new TextBox();
            tbxdias = new TextBox();
            labeldias = new Label();
            tbxhospede = new TextBox();
            labelnomehospede = new Label();
            labelfuncionario = new Label();
            cbxfuncionario = new ComboBox();
            dataGridView1 = new DataGridView();
            labeltotal = new Label();
            lblTotal = new Label();
            btnRemove = new Button();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            labeldatanascimento = new Label();
            txttelefone = new MaskedTextBox();
            labeltelefone = new Label();
            gpbquarto = new GroupBox();
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker3 = new DateTimePicker();
            gpbhospede = new GroupBox();
            dataGridView2 = new DataGridView();
            maskedTextBox1 = new MaskedTextBox();
            Paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            gpbquarto.SuspendLayout();
            gpbhospede.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // Paneltop
            // 
            Paneltop.BackColor = Color.FromArgb(4, 99, 125);
            Paneltop.Controls.Add(btnconsultar);
            Paneltop.Controls.Add(Btnreservar);
            Paneltop.Controls.Add(txtreservas);
            Paneltop.Controls.Add(BtnSair);
            Paneltop.Dock = DockStyle.Top;
            Paneltop.Location = new Point(0, 0);
            Paneltop.Margin = new Padding(4, 3, 4, 3);
            Paneltop.Name = "Paneltop";
            Paneltop.Size = new Size(1980, 95);
            Paneltop.TabIndex = 2;
            // 
            // btnconsultar
            // 
            btnconsultar.BackColor = SystemColors.ButtonFace;
            btnconsultar.Cursor = Cursors.Hand;
            btnconsultar.FlatAppearance.BorderColor = Color.FromArgb(4, 99, 125);
            btnconsultar.FlatAppearance.MouseOverBackColor = Color.FromArgb(4, 99, 125);
            btnconsultar.FlatStyle = FlatStyle.Flat;
            btnconsultar.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnconsultar.ForeColor = Color.FromArgb(4, 99, 125);
            btnconsultar.Location = new Point(1018, 12);
            btnconsultar.Margin = new Padding(4, 3, 4, 3);
            btnconsultar.Name = "btnconsultar";
            btnconsultar.Size = new Size(245, 60);
            btnconsultar.TabIndex = 28;
            btnconsultar.Text = "CONSULTAR RESERVAS";
            btnconsultar.UseVisualStyleBackColor = false;
            // 
            // Btnreservar
            // 
            Btnreservar.BackColor = SystemColors.ButtonFace;
            Btnreservar.Cursor = Cursors.Hand;
            Btnreservar.FlatAppearance.BorderColor = Color.FromArgb(4, 99, 125);
            Btnreservar.FlatAppearance.MouseOverBackColor = Color.FromArgb(4, 99, 125);
            Btnreservar.FlatStyle = FlatStyle.Flat;
            Btnreservar.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btnreservar.ForeColor = Color.FromArgb(4, 99, 125);
            Btnreservar.Location = new Point(564, 12);
            Btnreservar.Margin = new Padding(4, 3, 4, 3);
            Btnreservar.Name = "Btnreservar";
            Btnreservar.Size = new Size(245, 60);
            Btnreservar.TabIndex = 27;
            Btnreservar.Text = "CRIAR RESERVA";
            Btnreservar.UseVisualStyleBackColor = false;
            // 
            // txtreservas
            // 
            txtreservas.AutoSize = true;
            txtreservas.BackColor = SystemColors.ButtonFace;
            txtreservas.Font = new Font("Nirmala UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtreservas.ForeColor = Color.FromArgb(4, 99, 125);
            txtreservas.Location = new Point(29, 22);
            txtreservas.Margin = new Padding(4, 0, 4, 0);
            txtreservas.Name = "txtreservas";
            txtreservas.Size = new Size(172, 50);
            txtreservas.TabIndex = 6;
            txtreservas.Text = "Reservas";
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
            BtnSair.Location = new Point(1895, 0);
            BtnSair.Margin = new Padding(4, 3, 4, 3);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(85, 95);
            BtnSair.TabIndex = 5;
            BtnSair.UseVisualStyleBackColor = true;
            BtnSair.Click += BtnSair_Click;
            // 
            // labelquarto
            // 
            labelquarto.AutoSize = true;
            labelquarto.BackColor = Color.FromArgb(118, 177, 206);
            labelquarto.FlatStyle = FlatStyle.Flat;
            labelquarto.Font = new Font("Nirmala UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelquarto.ForeColor = SystemColors.ButtonFace;
            labelquarto.Location = new Point(15, 50);
            labelquarto.Name = "labelquarto";
            labelquarto.Size = new Size(66, 23);
            labelquarto.TabIndex = 7;
            labelquarto.Text = "Quarto";
            // 
            // cbquarto
            // 
            cbquarto.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbquarto.FormattingEnabled = true;
            cbquarto.Location = new Point(82, 49);
            cbquarto.Name = "cbquarto";
            cbquarto.Size = new Size(185, 25);
            cbquarto.TabIndex = 8;
            // 
            // labelvalordiaria
            // 
            labelvalordiaria.AutoSize = true;
            labelvalordiaria.BackColor = Color.FromArgb(118, 177, 206);
            labelvalordiaria.FlatStyle = FlatStyle.Flat;
            labelvalordiaria.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelvalordiaria.ForeColor = SystemColors.ButtonFace;
            labelvalordiaria.Location = new Point(306, 139);
            labelvalordiaria.Name = "labelvalordiaria";
            labelvalordiaria.Size = new Size(143, 25);
            labelvalordiaria.TabIndex = 13;
            labelvalordiaria.Text = "Valor da Diária";
            // 
            // tbxvalordiaria
            // 
            tbxvalordiaria.Cursor = Cursors.IBeam;
            tbxvalordiaria.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbxvalordiaria.Location = new Point(450, 139);
            tbxvalordiaria.Name = "tbxvalordiaria";
            tbxvalordiaria.Size = new Size(100, 25);
            tbxvalordiaria.TabIndex = 14;
            // 
            // tbxdias
            // 
            tbxdias.Cursor = Cursors.IBeam;
            tbxdias.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbxdias.Location = new Point(67, 139);
            tbxdias.Name = "tbxdias";
            tbxdias.Size = new Size(53, 25);
            tbxdias.TabIndex = 16;
            // 
            // labeldias
            // 
            labeldias.AutoSize = true;
            labeldias.BackColor = Color.FromArgb(118, 177, 206);
            labeldias.FlatStyle = FlatStyle.Flat;
            labeldias.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labeldias.ForeColor = SystemColors.ButtonFace;
            labeldias.Location = new Point(16, 139);
            labeldias.Name = "labeldias";
            labeldias.Size = new Size(49, 25);
            labeldias.TabIndex = 15;
            labeldias.Text = "Dias";
            // 
            // tbxhospede
            // 
            tbxhospede.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxhospede.Location = new Point(187, 40);
            tbxhospede.Name = "tbxhospede";
            tbxhospede.Size = new Size(282, 25);
            tbxhospede.TabIndex = 18;
            // 
            // labelnomehospede
            // 
            labelnomehospede.AutoSize = true;
            labelnomehospede.BackColor = Color.FromArgb(118, 177, 206);
            labelnomehospede.FlatStyle = FlatStyle.Flat;
            labelnomehospede.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelnomehospede.ForeColor = SystemColors.ButtonFace;
            labelnomehospede.Location = new Point(8, 40);
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
            labelfuncionario.Location = new Point(21, 190);
            labelfuncionario.Name = "labelfuncionario";
            labelfuncionario.Size = new Size(143, 25);
            labelfuncionario.TabIndex = 19;
            labelfuncionario.Text = "Funcionário(a)";
            // 
            // cbxfuncionario
            // 
            cbxfuncionario.FormattingEnabled = true;
            cbxfuncionario.Location = new Point(170, 190);
            cbxfuncionario.Name = "cbxfuncionario";
            cbxfuncionario.Size = new Size(249, 33);
            cbxfuncionario.TabIndex = 22;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1274, 603);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(339, 300);
            dataGridView1.TabIndex = 24;
            // 
            // labeltotal
            // 
            labeltotal.AutoSize = true;
            labeltotal.BackColor = Color.FromArgb(118, 177, 206);
            labeltotal.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labeltotal.ForeColor = SystemColors.ButtonFace;
            labeltotal.Location = new Point(1273, 113);
            labeltotal.Name = "labeltotal";
            labeltotal.Size = new Size(198, 25);
            labeltotal.TabIndex = 25;
            labeltotal.Text = "TOTAL DE RESERVAS:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.FromArgb(118, 177, 206);
            lblTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = SystemColors.ControlLightLight;
            lblTotal.Location = new Point(1471, 113);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(23, 25);
            lblTotal.TabIndex = 26;
            lblTotal.Text = "0";
            // 
            // btnRemove
            // 
            btnRemove.BackgroundImage = (Image)resources.GetObject("btnRemove.BackgroundImage");
            btnRemove.BackgroundImageLayout = ImageLayout.Stretch;
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemove.Location = new Point(1500, 113);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(25, 25);
            btnRemove.TabIndex = 27;
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(118, 177, 206);
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(8, 158);
            label1.Name = "label1";
            label1.Size = new Size(43, 25);
            label1.TabIndex = 72;
            label1.Text = "Cpf";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(198, 119);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(102, 25);
            dateTimePicker1.TabIndex = 71;
            dateTimePicker1.Value = new DateTime(2025, 7, 20, 15, 27, 19, 0);
            // 
            // labeldatanascimento
            // 
            labeldatanascimento.AutoSize = true;
            labeldatanascimento.BackColor = Color.FromArgb(118, 177, 206);
            labeldatanascimento.FlatStyle = FlatStyle.Flat;
            labeldatanascimento.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labeldatanascimento.ForeColor = SystemColors.ButtonFace;
            labeldatanascimento.Location = new Point(8, 119);
            labeldatanascimento.Name = "labeldatanascimento";
            labeldatanascimento.Size = new Size(190, 25);
            labeldatanascimento.TabIndex = 70;
            labeldatanascimento.Text = "Data de Nascimento";
            // 
            // txttelefone
            // 
            txttelefone.Cursor = Cursors.IBeam;
            txttelefone.Enabled = false;
            txttelefone.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txttelefone.Location = new Point(95, 80);
            txttelefone.Mask = "(99) 00000-0000";
            txttelefone.Name = "txttelefone";
            txttelefone.Size = new Size(100, 25);
            txttelefone.TabIndex = 69;
            // 
            // labeltelefone
            // 
            labeltelefone.AutoSize = true;
            labeltelefone.BackColor = Color.FromArgb(118, 177, 206);
            labeltelefone.FlatStyle = FlatStyle.Flat;
            labeltelefone.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labeltelefone.ForeColor = SystemColors.ButtonFace;
            labeltelefone.Location = new Point(8, 80);
            labeltelefone.Name = "labeltelefone";
            labeltelefone.Size = new Size(87, 25);
            labeltelefone.TabIndex = 23;
            labeltelefone.Text = "Telefone";
            // 
            // gpbquarto
            // 
            gpbquarto.BackColor = SystemColors.ButtonFace;
            gpbquarto.Controls.Add(label3);
            gpbquarto.Controls.Add(dateTimePicker3);
            gpbquarto.Controls.Add(label2);
            gpbquarto.Controls.Add(dateTimePicker2);
            gpbquarto.Controls.Add(tbxvalordiaria);
            gpbquarto.Controls.Add(labelvalordiaria);
            gpbquarto.Controls.Add(tbxdias);
            gpbquarto.Controls.Add(labeldias);
            gpbquarto.Controls.Add(cbxfuncionario);
            gpbquarto.Controls.Add(labelfuncionario);
            gpbquarto.Controls.Add(cbquarto);
            gpbquarto.Controls.Add(labelquarto);
            gpbquarto.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gpbquarto.ForeColor = Color.FromArgb(118, 177, 206);
            gpbquarto.Location = new Point(23, 438);
            gpbquarto.Name = "gpbquarto";
            gpbquarto.Size = new Size(550, 300);
            gpbquarto.TabIndex = 29;
            gpbquarto.TabStop = false;
            gpbquarto.Text = "Informações do Quarto";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(170, 94);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(116, 25);
            dateTimePicker2.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(118, 177, 206);
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(15, 94);
            label2.Name = "label2";
            label2.Size = new Size(154, 25);
            label2.TabIndex = 16;
            label2.Text = "Data de Entrada";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(118, 177, 206);
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(316, 94);
            label3.Name = "label3";
            label3.Size = new Size(133, 25);
            label3.TabIndex = 18;
            label3.Text = "Data de Saída";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker3.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Location = new Point(450, 94);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(116, 25);
            dateTimePicker3.TabIndex = 17;
            // 
            // gpbhospede
            // 
            gpbhospede.BackColor = SystemColors.ButtonFace;
            gpbhospede.Controls.Add(maskedTextBox1);
            gpbhospede.Controls.Add(tbxhospede);
            gpbhospede.Controls.Add(label1);
            gpbhospede.Controls.Add(labelnomehospede);
            gpbhospede.Controls.Add(dateTimePicker1);
            gpbhospede.Controls.Add(labeltelefone);
            gpbhospede.Controls.Add(labeldatanascimento);
            gpbhospede.Controls.Add(txttelefone);
            gpbhospede.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gpbhospede.ForeColor = Color.FromArgb(118, 177, 206);
            gpbhospede.Location = new Point(23, 113);
            gpbhospede.Name = "gpbhospede";
            gpbhospede.Size = new Size(550, 300);
            gpbhospede.TabIndex = 30;
            gpbhospede.TabStop = false;
            gpbhospede.Text = "Informações de Hóspede";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.ButtonFace;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.GridColor = SystemColors.MenuBar;
            dataGridView2.Location = new Point(1274, 141);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(694, 441);
            dataGridView2.TabIndex = 31;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maskedTextBox1.Location = new Point(51, 158);
            maskedTextBox1.Mask = "000.000.000-00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(83, 25);
            maskedTextBox1.TabIndex = 74;
            // 
            // FrmReservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1980, 973);
            Controls.Add(dataGridView2);
            Controls.Add(gpbhospede);
            Controls.Add(gpbquarto);
            Controls.Add(btnRemove);
            Controls.Add(lblTotal);
            Controls.Add(labeltotal);
            Controls.Add(dataGridView1);
            Controls.Add(Paneltop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmReservas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmReservas";
            Load += FrmReservas_Load;
            Paneltop.ResumeLayout(false);
            Paneltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            gpbquarto.ResumeLayout(false);
            gpbquarto.PerformLayout();
            gpbhospede.ResumeLayout(false);
            gpbhospede.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Paneltop;
        private Button BtnSair;
        private Label txtreservas;
        private Label labelquarto;
        private ComboBox cbquarto;
        private Label labelvalordiaria;
        private TextBox tbxvalordiaria;
        private TextBox tbxdias;
        private Label labeldias;
        private TextBox tbxhospede;
        private Label labelnomehospede;
        private Label labelfuncionario;
        private ComboBox cbxfuncionario;
        private Button Btnreservar;
        private Button btnconsultar;
        private DataGridView dataGridView1;
        private Label labeltotal;
        private Label lblTotal;
        private Button btnRemove;
        private Label labeltelefone;
        private MaskedTextBox txttelefone;
        private DateTimePicker dateTimePicker1;
        private Label labeldatanascimento;
        private Label label1;
        private GroupBox gpbquarto;
        private Label label3;
        private DateTimePicker dateTimePicker3;
        private Label label2;
        private DateTimePicker dateTimePicker2;
        private GroupBox gpbhospede;
        private DataGridView dataGridView2;
        private MaskedTextBox maskedTextBox1;
    }
}
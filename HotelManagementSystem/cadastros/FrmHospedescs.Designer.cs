namespace HotelManagementSystem.cadastros
{
    partial class FrmHospedescs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHospedescs));
            Paneltop = new Panel();
            txtreservas = new Label();
            BtnSair = new Button();
            gpbHospede = new GroupBox();
            checkBox1 = new CheckBox();
            label2 = new Label();
            btnsalvarhospede = new Button();
            txtcpf = new MaskedTextBox();
            label1 = new Label();
            labelnomehospede = new Label();
            datanasc = new DateTimePicker();
            tbxhospede = new TextBox();
            labeldatanascimento = new Label();
            labeltelefone = new Label();
            txttelefone = new MaskedTextBox();
            comboBox1 = new ComboBox();
            Paneltop.SuspendLayout();
            gpbHospede.SuspendLayout();
            SuspendLayout();
            // 
            // Paneltop
            // 
            Paneltop.BackColor = Color.FromArgb(4, 99, 125);
            Paneltop.Controls.Add(txtreservas);
            Paneltop.Controls.Add(BtnSair);
            Paneltop.Dock = DockStyle.Top;
            Paneltop.Location = new Point(0, 0);
            Paneltop.Margin = new Padding(5, 4, 5, 4);
            Paneltop.Name = "Paneltop";
            Paneltop.Size = new Size(1000, 100);
            Paneltop.TabIndex = 3;
            // 
            // txtreservas
            // 
            txtreservas.AutoSize = true;
            txtreservas.BackColor = SystemColors.ButtonFace;
            txtreservas.Font = new Font("Nirmala UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtreservas.ForeColor = Color.FromArgb(4, 99, 125);
            txtreservas.Location = new Point(29, 19);
            txtreservas.Margin = new Padding(5, 0, 5, 0);
            txtreservas.Name = "txtreservas";
            txtreservas.Size = new Size(242, 62);
            txtreservas.TabIndex = 6;
            txtreservas.Text = "Hóspedes";
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
            BtnSair.Location = new Point(903, 0);
            BtnSair.Margin = new Padding(5, 4, 5, 4);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(97, 100);
            BtnSair.TabIndex = 5;
            BtnSair.UseVisualStyleBackColor = true;
            BtnSair.Click += BtnSair_Click;
            // 
            // gpbHospede
            // 
            gpbHospede.BackColor = Color.White;
            gpbHospede.Controls.Add(comboBox1);
            gpbHospede.Controls.Add(checkBox1);
            gpbHospede.Controls.Add(label2);
            gpbHospede.Controls.Add(btnsalvarhospede);
            gpbHospede.Controls.Add(txtcpf);
            gpbHospede.Controls.Add(label1);
            gpbHospede.Controls.Add(labelnomehospede);
            gpbHospede.Controls.Add(datanasc);
            gpbHospede.Controls.Add(tbxhospede);
            gpbHospede.Controls.Add(labeldatanascimento);
            gpbHospede.Controls.Add(labeltelefone);
            gpbHospede.Controls.Add(txttelefone);
            gpbHospede.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gpbHospede.ForeColor = Color.Black;
            gpbHospede.Location = new Point(10, 108);
            gpbHospede.Margin = new Padding(3, 4, 3, 4);
            gpbHospede.Name = "gpbHospede";
            gpbHospede.Padding = new Padding(3, 4, 3, 4);
            gpbHospede.Size = new Size(980, 260);
            gpbHospede.TabIndex = 30;
            gpbHospede.TabStop = false;
            gpbHospede.Text = "Informações do Hóspede";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.FromArgb(17, 107, 132);
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.FlatAppearance.BorderColor = Color.FromArgb(17, 107, 132);
            checkBox1.FlatAppearance.BorderSize = 5;
            checkBox1.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(15, 184);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(106, 29);
            checkBox1.TabIndex = 75;
            checkBox1.Text = "Empresa";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(118, 177, 206);
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(23, 268);
            label2.Name = "label2";
            label2.Size = new Size(0, 32);
            label2.TabIndex = 74;
            // 
            // btnsalvarhospede
            // 
            btnsalvarhospede.BackColor = Color.FromArgb(4, 99, 125);
            btnsalvarhospede.FlatAppearance.BorderSize = 0;
            btnsalvarhospede.FlatStyle = FlatStyle.Flat;
            btnsalvarhospede.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsalvarhospede.ForeColor = SystemColors.ButtonFace;
            btnsalvarhospede.Location = new Point(791, 205);
            btnsalvarhospede.Margin = new Padding(3, 4, 3, 4);
            btnsalvarhospede.Name = "btnsalvarhospede";
            btnsalvarhospede.Size = new Size(152, 33);
            btnsalvarhospede.TabIndex = 73;
            btnsalvarhospede.Text = "Salvar informações";
            btnsalvarhospede.UseVisualStyleBackColor = false;
            // 
            // txtcpf
            // 
            txtcpf.Font = new Font("Nirmala UI", 10.8F);
            txtcpf.Location = new Point(69, 112);
            txtcpf.Margin = new Padding(3, 4, 3, 4);
            txtcpf.Mask = "000.000.000-00";
            txtcpf.Name = "txtcpf";
            txtcpf.Size = new Size(114, 31);
            txtcpf.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(17, 107, 132);
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 112);
            label1.Name = "label1";
            label1.Size = new Size(54, 31);
            label1.TabIndex = 72;
            label1.Text = "CPF";
            // 
            // labelnomehospede
            // 
            labelnomehospede.AutoSize = true;
            labelnomehospede.BackColor = Color.FromArgb(17, 107, 132);
            labelnomehospede.FlatStyle = FlatStyle.Flat;
            labelnomehospede.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelnomehospede.ForeColor = Color.White;
            labelnomehospede.Location = new Point(15, 58);
            labelnomehospede.Name = "labelnomehospede";
            labelnomehospede.Size = new Size(213, 31);
            labelnomehospede.TabIndex = 17;
            labelnomehospede.Text = "Nome do Hóspede";
            // 
            // datanasc
            // 
            datanasc.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datanasc.Format = DateTimePickerFormat.Custom;
            datanasc.Location = new Point(812, 58);
            datanasc.Margin = new Padding(3, 4, 3, 4);
            datanasc.MaxDate = new DateTime(2025, 12, 31, 0, 0, 0, 0);
            datanasc.MinDate = new DateTime(1910, 1, 1, 0, 0, 0, 0);
            datanasc.Name = "datanasc";
            datanasc.Size = new Size(141, 31);
            datanasc.TabIndex = 71;
            datanasc.Value = new DateTime(2025, 7, 20, 0, 0, 0, 0);
            // 
            // tbxhospede
            // 
            tbxhospede.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxhospede.Location = new Point(228, 58);
            tbxhospede.Margin = new Padding(3, 4, 3, 4);
            tbxhospede.Name = "tbxhospede";
            tbxhospede.Size = new Size(312, 31);
            tbxhospede.TabIndex = 18;
            // 
            // labeldatanascimento
            // 
            labeldatanascimento.AutoSize = true;
            labeldatanascimento.BackColor = Color.FromArgb(17, 107, 132);
            labeldatanascimento.FlatStyle = FlatStyle.Flat;
            labeldatanascimento.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labeldatanascimento.ForeColor = Color.White;
            labeldatanascimento.Location = new Point(582, 58);
            labeldatanascimento.Name = "labeldatanascimento";
            labeldatanascimento.Size = new Size(230, 31);
            labeldatanascimento.TabIndex = 70;
            labeldatanascimento.Text = "Data de Nascimento";
            // 
            // labeltelefone
            // 
            labeltelefone.AutoSize = true;
            labeltelefone.BackColor = Color.FromArgb(17, 107, 132);
            labeltelefone.FlatStyle = FlatStyle.Flat;
            labeltelefone.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold);
            labeltelefone.ForeColor = Color.White;
            labeltelefone.Location = new Point(319, 112);
            labeltelefone.Name = "labeltelefone";
            labeltelefone.Size = new Size(105, 31);
            labeltelefone.TabIndex = 23;
            labeltelefone.Text = "Telefone";
            // 
            // txttelefone
            // 
            txttelefone.Cursor = Cursors.IBeam;
            txttelefone.Enabled = false;
            txttelefone.Font = new Font("Nirmala UI", 10.8F);
            txttelefone.Location = new Point(425, 112);
            txttelefone.Margin = new Padding(3, 4, 3, 4);
            txttelefone.Mask = "(99) 00000-0000";
            txttelefone.Name = "txttelefone";
            txttelefone.Size = new Size(114, 31);
            txttelefone.TabIndex = 69;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(802, 112);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 33);
            comboBox1.TabIndex = 76;
            // 
            // FrmHospedescs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 239, 242);
            ClientSize = new Size(1000, 800);
            Controls.Add(gpbHospede);
            Controls.Add(Paneltop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmHospedescs";
            Text = "FrmHospedescs";
            Paneltop.ResumeLayout(false);
            Paneltop.PerformLayout();
            gpbHospede.ResumeLayout(false);
            gpbHospede.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Paneltop;
        private Label txtreservas;
        private Button BtnSair;
        private GroupBox gpbHospede;
        private Label label2;
        private Button btnsalvarhospede;
        private MaskedTextBox txtcpf;
        private Label label1;
        private Label labelnomehospede;
        private DateTimePicker datanasc;
        private TextBox tbxhospede;
        private Label labeldatanascimento;
        private Label labeltelefone;
        private MaskedTextBox txttelefone;
        private CheckBox checkBox1;
        private ComboBox comboBox1;
    }
}
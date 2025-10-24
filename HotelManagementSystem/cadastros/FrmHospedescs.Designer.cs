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
            button1 = new Button();
            button2 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            panel1 = new Panel();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            button4 = new Button();
            panel2 = new Panel();
            Paneltop.SuspendLayout();
            gpbHospede.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
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
            gpbHospede.Controls.Add(label2);
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
            gpbHospede.Size = new Size(578, 263);
            gpbHospede.TabIndex = 30;
            gpbHospede.TabStop = false;
            gpbHospede.Text = "Informações do Hóspede";
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
            btnsalvarhospede.BackColor = Color.Goldenrod;
            btnsalvarhospede.FlatAppearance.BorderSize = 0;
            btnsalvarhospede.FlatStyle = FlatStyle.Flat;
            btnsalvarhospede.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsalvarhospede.ForeColor = SystemColors.ButtonFace;
            btnsalvarhospede.Location = new Point(109, 82);
            btnsalvarhospede.Margin = new Padding(3, 4, 3, 4);
            btnsalvarhospede.Name = "btnsalvarhospede";
            btnsalvarhospede.Size = new Size(152, 33);
            btnsalvarhospede.TabIndex = 73;
            btnsalvarhospede.Text = "Limpar";
            btnsalvarhospede.UseVisualStyleBackColor = false;
            // 
            // txtcpf
            // 
            txtcpf.Font = new Font("Nirmala UI", 10.8F);
            txtcpf.Location = new Point(70, 148);
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
            label1.Location = new Point(15, 148);
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
            datanasc.Location = new Point(246, 196);
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
            tbxhospede.Location = new Point(229, 58);
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
            labeldatanascimento.Location = new Point(15, 196);
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
            labeltelefone.Location = new Point(15, 103);
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
            txttelefone.Location = new Point(121, 103);
            txttelefone.Margin = new Padding(3, 4, 3, 4);
            txttelefone.Mask = "(99) 00000-0000";
            txttelefone.Name = "txttelefone";
            txttelefone.Size = new Size(114, 31);
            txttelefone.TabIndex = 69;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(109, 123);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(152, 33);
            button1.TabIndex = 75;
            button1.Text = "Ir para Reserva";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.ForestGreen;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(109, 41);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(152, 33);
            button2.TabIndex = 76;
            button2.Text = "Salvar";
            button2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Nirmala UI Semilight", 10.8F);
            radioButton1.Location = new Point(39, 3);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(80, 29);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Nome";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Nirmala UI Semilight", 10.8F);
            radioButton2.Location = new Point(39, 38);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(96, 29);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Telefone";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Location = new Point(10, 411);
            panel1.Name = "panel1";
            panel1.Size = new Size(980, 74);
            panel1.TabIndex = 32;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(343, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(273, 27);
            textBox1.TabIndex = 33;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 485);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(980, 303);
            dataGridView1.TabIndex = 33;
            // 
            // button3
            // 
            button3.BackColor = Color.Teal;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(109, 167);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(152, 33);
            button3.TabIndex = 76;
            button3.Text = "Pesquisar";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(192, 0, 0);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(790, 21);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(169, 33);
            button4.TabIndex = 77;
            button4.Text = "Excluir Hóspede";
            button4.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnsalvarhospede);
            panel2.Location = new Point(607, 107);
            panel2.Name = "panel2";
            panel2.Size = new Size(372, 264);
            panel2.TabIndex = 34;
            // 
            // FrmHospedescs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 239, 242);
            ClientSize = new Size(1000, 800);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(gpbHospede);
            Controls.Add(Paneltop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmHospedescs";
            Text = "FrmHospedescs";
            Paneltop.ResumeLayout(false);
            Paneltop.PerformLayout();
            gpbHospede.ResumeLayout(false);
            gpbHospede.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
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
        private Button button2;
        private Button button1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Panel panel1;
        private Button button3;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button button4;
        private Panel panel2;
    }
}
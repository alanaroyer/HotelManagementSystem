namespace HotelManagementSystem.cadastros
{
    partial class FrmConsultarReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarReserva));
            Paneltop = new Panel();
            button1 = new Button();
            textBox1 = new TextBox();
            txtfuncionario = new Label();
            BtnSair = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            Paneltop.SuspendLayout();
            SuspendLayout();
            // 
            // Paneltop
            // 
            Paneltop.BackColor = Color.FromArgb(4, 99, 125);
            Paneltop.Controls.Add(button1);
            Paneltop.Controls.Add(textBox1);
            Paneltop.Controls.Add(radioButton1);
            Paneltop.Controls.Add(radioButton2);
            Paneltop.Controls.Add(txtfuncionario);
            Paneltop.Controls.Add(BtnSair);
            Paneltop.Dock = DockStyle.Top;
            Paneltop.Location = new Point(0, 0);
            Paneltop.Margin = new Padding(4, 3, 4, 3);
            Paneltop.Name = "Paneltop";
            Paneltop.Size = new Size(1000, 95);
            Paneltop.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(659, 37);
            button1.Name = "button1";
            button1.Size = new Size(35, 35);
            button1.TabIndex = 8;
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(505, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(148, 25);
            textBox1.TabIndex = 7;
            // 
            // txtfuncionario
            // 
            txtfuncionario.AutoSize = true;
            txtfuncionario.BackColor = SystemColors.ButtonFace;
            txtfuncionario.Font = new Font("Nirmala UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtfuncionario.ForeColor = Color.FromArgb(4, 99, 125);
            txtfuncionario.Location = new Point(38, 22);
            txtfuncionario.Margin = new Padding(4, 0, 4, 0);
            txtfuncionario.Name = "txtfuncionario";
            txtfuncionario.Size = new Size(188, 50);
            txtfuncionario.TabIndex = 6;
            txtfuncionario.Text = "Consultar";
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
            BtnSair.Location = new Point(915, 0);
            BtnSair.Margin = new Padding(4, 3, 4, 3);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(85, 95);
            BtnSair.TabIndex = 5;
            BtnSair.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(387, 48);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(79, 24);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "Reserva";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(387, 12);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(87, 24);
            radioButton2.TabIndex = 9;
            radioButton2.TabStop = true;
            radioButton2.Text = "Hóspede";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // FrmConsultarReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 800);
            Controls.Add(Paneltop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmConsultarReserva";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmConsultarReserva";
            Paneltop.ResumeLayout(false);
            Paneltop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Paneltop;
        private Label txtfuncionario;
        private Button BtnSair;
        private Button button1;
        private TextBox textBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    }
}
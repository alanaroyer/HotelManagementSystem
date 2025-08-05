namespace HotelManagementSystem.cadastros
{
    partial class FrmCadFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadFuncionario));
            Paneltop = new Panel();
            button1 = new Button();
            textBox1 = new TextBox();
            txtfuncionario = new Label();
            BtnSair = new Button();
            Paneltop.SuspendLayout();
            SuspendLayout();
            // 
            // Paneltop
            // 
            Paneltop.BackColor = Color.FromArgb(4, 99, 125);
            Paneltop.Controls.Add(button1);
            Paneltop.Controls.Add(textBox1);
            Paneltop.Controls.Add(txtfuncionario);
            Paneltop.Controls.Add(BtnSair);
            Paneltop.Dock = DockStyle.Top;
            Paneltop.Location = new Point(0, 0);
            Paneltop.Margin = new Padding(4, 3, 4, 3);
            Paneltop.Name = "Paneltop";
            Paneltop.Size = new Size(1000, 95);
            Paneltop.TabIndex = 3;
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
            button1.Location = new Point(642, 22);
            button1.Name = "button1";
            button1.Size = new Size(35, 35);
            button1.TabIndex = 8;
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(488, 27);
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
            txtfuncionario.Size = new Size(244, 50);
            txtfuncionario.TabIndex = 6;
            txtfuncionario.Text = "Funcionários";
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
            BtnSair.Click += BtnSair_Click;
            // 
            // FrmCadFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 800);
            Controls.Add(Paneltop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCadFuncionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCadFuncionario";
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
    }
}
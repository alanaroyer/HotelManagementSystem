namespace HotelManagementSystem.menu
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            PaneltopoLogin = new Panel();
            BtnSair = new Button();
            panel1 = new Panel();
            PaneltopoLogin.SuspendLayout();
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
            PaneltopoLogin.Size = new Size(1920, 60);
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
            BtnSair.Location = new Point(1860, 0);
            BtnSair.Margin = new Padding(4, 3, 4, 3);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(60, 60);
            BtnSair.TabIndex = 5;
            BtnSair.UseVisualStyleBackColor = true;
            BtnSair.Click += BtnSair_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(4, 99, 125);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 913);
            panel1.TabIndex = 3;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 973);
            Controls.Add(panel1);
            Controls.Add(PaneltopoLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMenu";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmMenu";
            PaneltopoLogin.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PaneltopoLogin;
        private Button BtnSair;
        private Panel panel1;
    }
}
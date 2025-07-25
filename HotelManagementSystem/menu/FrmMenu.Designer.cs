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
            txtmenu = new Label();
            BtnSair = new Button();
            panelleft = new Panel();
            PaneltopoLogin.SuspendLayout();
            SuspendLayout();
            // 
            // PaneltopoLogin
            // 
            PaneltopoLogin.BackColor = Color.FromArgb(4, 99, 125);
            PaneltopoLogin.Controls.Add(txtmenu);
            PaneltopoLogin.Controls.Add(BtnSair);
            PaneltopoLogin.Dock = DockStyle.Top;
            PaneltopoLogin.Location = new Point(0, 0);
            PaneltopoLogin.Margin = new Padding(4, 3, 4, 3);
            PaneltopoLogin.Name = "PaneltopoLogin";
            PaneltopoLogin.Size = new Size(1200, 95);
            PaneltopoLogin.TabIndex = 2;
            // 
            // txtmenu
            // 
            txtmenu.AutoSize = true;
            txtmenu.BackColor = SystemColors.ButtonFace;
            txtmenu.Font = new Font("Nirmala UI", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtmenu.ForeColor = Color.FromArgb(4, 99, 125);
            txtmenu.Location = new Point(100, 15);
            txtmenu.Margin = new Padding(4, 0, 4, 0);
            txtmenu.Name = "txtmenu";
            txtmenu.Size = new Size(141, 59);
            txtmenu.TabIndex = 7;
            txtmenu.Text = "Menu";
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
            // panelleft
            // 
            panelleft.BackColor = Color.FromArgb(4, 99, 125);
            panelleft.Dock = DockStyle.Left;
            panelleft.Location = new Point(0, 95);
            panelleft.Name = "panelleft";
            panelleft.Size = new Size(300, 705);
            panelleft.TabIndex = 3;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 800);
            Controls.Add(panelleft);
            Controls.Add(PaneltopoLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMenu";
            PaneltopoLogin.ResumeLayout(false);
            PaneltopoLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PaneltopoLogin;
        private Button BtnSair;
        private Panel panelleft;
        private Label txtmenu;
    }
}
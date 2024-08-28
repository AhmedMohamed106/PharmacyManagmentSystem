namespace PharmacyManagmentSystem.UI.Forms
{
    partial class Landing
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            label1 = new Label();
            textBox14 = new TextBox();
            textBox8 = new TextBox();
            Password = new Label();
            userName = new Label();
            login = new Button();
            groupBox1 = new GroupBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(guna2ControlBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1087, 58);
            panel1.TabIndex = 1;
            // 
            // guna2ControlBox1
            // 
            guna2ControlBox1.Anchor = AnchorStyles.Right;
            guna2ControlBox1.BackColor = Color.Gray;
            guna2ControlBox1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            guna2ControlBox1.CustomizableEdges = customizableEdges1;
            guna2ControlBox1.FillColor = Color.FromArgb(0, 0, 0, 0);
            guna2ControlBox1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            guna2ControlBox1.IconColor = Color.White;
            guna2ControlBox1.Location = new Point(1931, -10);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ControlBox1.Size = new Size(31, 37);
            guna2ControlBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(532, 9);
            label1.Name = "label1";
            label1.Size = new Size(387, 37);
            label1.TabIndex = 0;
            label1.Text = "Pharmacy Management System";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox14
            // 
            textBox14.Location = new Point(95, 76);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(161, 23);
            textBox14.TabIndex = 7;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(95, 28);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(161, 23);
            textBox8.TabIndex = 8;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Password.Location = new Point(11, 76);
            Password.Name = "Password";
            Password.Size = new Size(76, 20);
            Password.TabIndex = 5;
            Password.Text = "Password";
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            userName.Location = new Point(11, 29);
            userName.Name = "userName";
            userName.Size = new Size(80, 20);
            userName.TabIndex = 6;
            userName.Text = "Username";
            // 
            // login
            // 
            login.Location = new Point(116, 122);
            login.Name = "login";
            login.Size = new Size(118, 39);
            login.TabIndex = 9;
            login.Text = "Login";
            login.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(login);
            groupBox1.Controls.Add(textBox14);
            groupBox1.Controls.Add(userName);
            groupBox1.Controls.Add(textBox8);
            groupBox1.Controls.Add(Password);
            groupBox1.Location = new Point(385, 149);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(284, 190);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // Landing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 586);
            ControlBox = false;
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "Landing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Label label1;
        private TextBox textBox14;
        private TextBox textBox8;
        private Label Password;
        private Label userName;
        private Button login;
        private GroupBox groupBox1;
    }
}
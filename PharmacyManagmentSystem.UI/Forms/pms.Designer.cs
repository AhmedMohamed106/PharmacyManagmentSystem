namespace PharmacyManagmentSystem.UI.Forms
{
    partial class pms
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            label1 = new Label();
            panel2 = new Panel();
            guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            loginTab = new TabPage();
            salesTab = new TabPage();
            purchaseTab = new TabPage();
            stockTab = new TabPage();
            salesReturnTab = new TabPage();
            PurchaseReturnTab = new TabPage();
            customersTab = new TabPage();
            reportsTab = new TabPage();
            accountTab = new TabPage();
            backupTab = new TabPage();
            groupBox1 = new GroupBox();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label8 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            guna2TabControl1.SuspendLayout();
            stockTab.SuspendLayout();
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
            panel1.TabIndex = 0;
            // 
            // guna2ControlBox1
            // 
            guna2ControlBox1.Anchor = AnchorStyles.Right;
            guna2ControlBox1.BackColor = Color.Gray;
            guna2ControlBox1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            guna2ControlBox1.CustomizableEdges = customizableEdges5;
            guna2ControlBox1.FillColor = Color.FromArgb(0, 0, 0, 0);
            guna2ControlBox1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            guna2ControlBox1.IconColor = Color.White;
            guna2ControlBox1.Location = new Point(1044, 11);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges6;
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
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(guna2TabControl1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(1087, 528);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // guna2TabControl1
            // 
            guna2TabControl1.Alignment = TabAlignment.Left;
            guna2TabControl1.Controls.Add(loginTab);
            guna2TabControl1.Controls.Add(salesTab);
            guna2TabControl1.Controls.Add(purchaseTab);
            guna2TabControl1.Controls.Add(stockTab);
            guna2TabControl1.Controls.Add(salesReturnTab);
            guna2TabControl1.Controls.Add(PurchaseReturnTab);
            guna2TabControl1.Controls.Add(customersTab);
            guna2TabControl1.Controls.Add(reportsTab);
            guna2TabControl1.Controls.Add(accountTab);
            guna2TabControl1.Controls.Add(backupTab);
            guna2TabControl1.Dock = DockStyle.Fill;
            guna2TabControl1.ItemSize = new Size(180, 40);
            guna2TabControl1.Location = new Point(0, 0);
            guna2TabControl1.Name = "guna2TabControl1";
            guna2TabControl1.SelectedIndex = 0;
            guna2TabControl1.Size = new Size(1087, 528);
            guna2TabControl1.TabButtonHoverState.BorderColor = Color.Empty;
            guna2TabControl1.TabButtonHoverState.FillColor = Color.FromArgb(40, 52, 70);
            guna2TabControl1.TabButtonHoverState.Font = new Font("Segoe UI Semibold", 10F);
            guna2TabControl1.TabButtonHoverState.ForeColor = Color.White;
            guna2TabControl1.TabButtonHoverState.InnerColor = Color.FromArgb(40, 52, 70);
            guna2TabControl1.TabButtonIdleState.BorderColor = Color.Empty;
            guna2TabControl1.TabButtonIdleState.FillColor = Color.FromArgb(33, 42, 57);
            guna2TabControl1.TabButtonIdleState.Font = new Font("Segoe UI Semibold", 10F);
            guna2TabControl1.TabButtonIdleState.ForeColor = Color.FromArgb(156, 160, 167);
            guna2TabControl1.TabButtonIdleState.InnerColor = Color.FromArgb(33, 42, 57);
            guna2TabControl1.TabButtonSelectedState.BorderColor = Color.FromArgb(64, 64, 64);
            guna2TabControl1.TabButtonSelectedState.FillColor = Color.Gray;
            guna2TabControl1.TabButtonSelectedState.Font = new Font("Segoe UI Semibold", 10F);
            guna2TabControl1.TabButtonSelectedState.ForeColor = Color.White;
            guna2TabControl1.TabButtonSelectedState.InnerColor = Color.FromArgb(224, 224, 224);
            guna2TabControl1.TabButtonSize = new Size(180, 40);
            guna2TabControl1.TabIndex = 0;
            guna2TabControl1.TabMenuBackColor = Color.DarkGray;
            // 
            // loginTab
            // 
            loginTab.Location = new Point(184, 4);
            loginTab.Name = "loginTab";
            loginTab.Size = new Size(899, 520);
            loginTab.TabIndex = 9;
            loginTab.Text = "Login";
            loginTab.UseVisualStyleBackColor = true;
            // 
            // salesTab
            // 
            salesTab.Location = new Point(184, 4);
            salesTab.Name = "salesTab";
            salesTab.Padding = new Padding(3);
            salesTab.Size = new Size(899, 520);
            salesTab.TabIndex = 1;
            salesTab.Text = "Sales";
            salesTab.UseVisualStyleBackColor = true;
            // 
            // purchaseTab
            // 
            purchaseTab.Location = new Point(184, 4);
            purchaseTab.Name = "purchaseTab";
            purchaseTab.Size = new Size(899, 520);
            purchaseTab.TabIndex = 2;
            purchaseTab.Text = "Purchase";
            purchaseTab.UseVisualStyleBackColor = true;
            // 
            // stockTab
            // 
            stockTab.Controls.Add(groupBox1);
            stockTab.Location = new Point(184, 4);
            stockTab.Name = "stockTab";
            stockTab.Size = new Size(899, 520);
            stockTab.TabIndex = 3;
            stockTab.Text = "Stock";
            stockTab.UseVisualStyleBackColor = true;
            
            // 
            // salesReturnTab
            // 
            salesReturnTab.Location = new Point(184, 4);
            salesReturnTab.Name = "salesReturnTab";
            salesReturnTab.Size = new Size(899, 520);
            salesReturnTab.TabIndex = 4;
            salesReturnTab.Text = "Sales Return";
            salesReturnTab.UseVisualStyleBackColor = true;
            // 
            // PurchaseReturnTab
            // 
            PurchaseReturnTab.Location = new Point(184, 4);
            PurchaseReturnTab.Name = "PurchaseReturnTab";
            PurchaseReturnTab.Size = new Size(899, 520);
            PurchaseReturnTab.TabIndex = 5;
            PurchaseReturnTab.Text = "Purchase Return";
            PurchaseReturnTab.UseVisualStyleBackColor = true;
            // 
            // customersTab
            // 
            customersTab.Location = new Point(184, 4);
            customersTab.Name = "customersTab";
            customersTab.Size = new Size(899, 520);
            customersTab.TabIndex = 8;
            customersTab.Text = "Customers";
            customersTab.UseVisualStyleBackColor = true;
            // 
            // reportsTab
            // 
            reportsTab.Location = new Point(184, 4);
            reportsTab.Name = "reportsTab";
            reportsTab.Size = new Size(899, 520);
            reportsTab.TabIndex = 7;
            reportsTab.Text = "Reports";
            reportsTab.UseVisualStyleBackColor = true;
            // 
            // accountTab
            // 
            accountTab.Location = new Point(184, 4);
            accountTab.Name = "accountTab";
            accountTab.Padding = new Padding(3);
            accountTab.Size = new Size(899, 520);
            accountTab.TabIndex = 0;
            accountTab.Text = "Account";
            accountTab.UseVisualStyleBackColor = true;
            accountTab.Click += tabPage1_Click;
            // 
            // backupTab
            // 
            backupTab.Location = new Point(184, 4);
            backupTab.Name = "backupTab";
            backupTab.Size = new Size(899, 520);
            backupTab.TabIndex = 6;
            backupTab.Text = "Backup";
            backupTab.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(17, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(874, 142);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Product";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(6, 29);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 0;
            label2.Text = "Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(63, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(551, 27);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(161, 23);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(438, 28);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 2;
            label3.Text = "Generic name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.Location = new Point(243, 29);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 4;
            label4.Text = "Form";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Tablet", "Capsule", "Injection", "Syrup", "", "Suspension", "", "Solution", "Oral Powder", "", "Effervescent Granules", "Cream", "", "Ointment", "", "Gel", "", "Lotion", "Suppository", "", "Enemas", "Eye Drop", "", "Eye Ointment", "Ear Drop", "", "Ear Ointment" });
            comboBox1.Location = new Point(295, 27);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(93, 70);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(161, 23);
            textBox3.TabIndex = 7;
            
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.Location = new Point(6, 71);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 6;
            label5.Text = "Company";
            
            // 
            // textBox4
            // 
            textBox4.Location = new Point(344, 70);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(144, 23);
            textBox4.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.Location = new Point(271, 71);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 8;
            label6.Text = "Barcode";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.Location = new Point(729, 28);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 8;
            label7.Text = "Units";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(782, 27);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(55, 23);
            textBox5.TabIndex = 9;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(555, 70);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(74, 23);
            textBox6.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label8.Location = new Point(505, 71);
            label8.Name = "label8";
            label8.Size = new Size(43, 20);
            label8.TabIndex = 10;
            label8.Text = "Price";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 8.25F);
            button1.Location = new Point(380, 113);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // pms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 586);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "pms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PMS";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            guna2TabControl1.ResumeLayout(false);
            stockTab.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private TabPage accountTab;
        private TabPage salesTab;
        private TabPage purchaseTab;
        private TabPage loginTab;
        private TabPage stockTab;
        private TabPage salesReturnTab;
        private TabPage PurchaseReturnTab;
        private TabPage customersTab;
        private TabPage reportsTab;
        private TabPage backupTab;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox6;
        private Label label8;
        private Button button1;
    }
}
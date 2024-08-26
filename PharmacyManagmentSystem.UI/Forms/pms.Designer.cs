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
            components = new System.ComponentModel.Container();
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            textBox6 = new TextBox();
            label8 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            salesReturnTab = new TabPage();
            PurchaseReturnTab = new TabPage();
            customersTab = new TabPage();
            reportsTab = new TabPage();
            accountTab = new TabPage();
            backupTab = new TabPage();
            groupBox2 = new GroupBox();
            btnSave = new Button();
            label9 = new Label();
            label11 = new Label();
            txtCName = new TextBox();
            label12 = new Label();
            txtCAddress = new TextBox();
            txtCPhone = new TextBox();
            btnUpdate = new Button();
            dataGridView1 = new DataGridView();
            customerBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            guna2TabControl1.SuspendLayout();
            stockTab.SuspendLayout();
            groupBox1.SuspendLayout();
            customersTab.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
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
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1242, 77);
            panel1.TabIndex = 0;
            // 
            // guna2ControlBox1
            // 
            guna2ControlBox1.Anchor = AnchorStyles.Right;
            guna2ControlBox1.BackColor = Color.Gray;
            guna2ControlBox1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            guna2ControlBox1.CustomizableEdges = customizableEdges5;
            guna2ControlBox1.FillColor = Color.FromArgb(0, 0, 0, 0);
            guna2ControlBox1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            guna2ControlBox1.IconColor = Color.White;
            guna2ControlBox1.Location = new Point(1193, 15);
            guna2ControlBox1.Margin = new Padding(3, 4, 3, 4);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2ControlBox1.Size = new Size(35, 49);
            guna2ControlBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(608, 12);
            label1.Name = "label1";
            label1.Size = new Size(489, 46);
            label1.TabIndex = 0;
            label1.Text = "Pharmacy Management System";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(guna2TabControl1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 77);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1242, 704);
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
            guna2TabControl1.Margin = new Padding(3, 4, 3, 4);
            guna2TabControl1.Name = "guna2TabControl1";
            guna2TabControl1.SelectedIndex = 0;
            guna2TabControl1.Size = new Size(1242, 704);
            guna2TabControl1.TabButtonHoverState.BorderColor = Color.Empty;
            guna2TabControl1.TabButtonHoverState.FillColor = Color.FromArgb(40, 52, 70);
            guna2TabControl1.TabButtonHoverState.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            guna2TabControl1.TabButtonHoverState.ForeColor = Color.White;
            guna2TabControl1.TabButtonHoverState.InnerColor = Color.FromArgb(40, 52, 70);
            guna2TabControl1.TabButtonIdleState.BorderColor = Color.Empty;
            guna2TabControl1.TabButtonIdleState.FillColor = Color.FromArgb(33, 42, 57);
            guna2TabControl1.TabButtonIdleState.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            guna2TabControl1.TabButtonIdleState.ForeColor = Color.FromArgb(156, 160, 167);
            guna2TabControl1.TabButtonIdleState.InnerColor = Color.FromArgb(33, 42, 57);
            guna2TabControl1.TabButtonSelectedState.BorderColor = Color.FromArgb(64, 64, 64);
            guna2TabControl1.TabButtonSelectedState.FillColor = Color.Gray;
            guna2TabControl1.TabButtonSelectedState.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            guna2TabControl1.TabButtonSelectedState.ForeColor = Color.White;
            guna2TabControl1.TabButtonSelectedState.InnerColor = Color.FromArgb(224, 224, 224);
            guna2TabControl1.TabButtonSize = new Size(180, 40);
            guna2TabControl1.TabIndex = 0;
            guna2TabControl1.TabMenuBackColor = Color.DarkGray;
            // 
            // loginTab
            // 
            loginTab.Location = new Point(184, 4);
            loginTab.Margin = new Padding(3, 4, 3, 4);
            loginTab.Name = "loginTab";
            loginTab.Size = new Size(1054, 696);
            loginTab.TabIndex = 9;
            loginTab.Text = "Login";
            loginTab.UseVisualStyleBackColor = true;
            // 
            // salesTab
            // 
            salesTab.Location = new Point(184, 4);
            salesTab.Margin = new Padding(3, 4, 3, 4);
            salesTab.Name = "salesTab";
            salesTab.Padding = new Padding(3, 4, 3, 4);
            salesTab.Size = new Size(1054, 696);
            salesTab.TabIndex = 1;
            salesTab.Text = "Sales";
            salesTab.UseVisualStyleBackColor = true;
            // 
            // purchaseTab
            // 
            purchaseTab.Location = new Point(184, 4);
            purchaseTab.Margin = new Padding(3, 4, 3, 4);
            purchaseTab.Name = "purchaseTab";
            purchaseTab.Size = new Size(1054, 696);
            purchaseTab.TabIndex = 2;
            purchaseTab.Text = "Purchase";
            purchaseTab.UseVisualStyleBackColor = true;
            // 
            // stockTab
            // 
            stockTab.Controls.Add(groupBox1);
            stockTab.Location = new Point(184, 4);
            stockTab.Margin = new Padding(3, 4, 3, 4);
            stockTab.Name = "stockTab";
            stockTab.Size = new Size(1054, 696);
            stockTab.TabIndex = 3;
            stockTab.Text = "Stock";
            stockTab.UseVisualStyleBackColor = true;
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
            groupBox1.Location = new Point(19, 21);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(999, 189);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Product";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(434, 151);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 12;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(634, 93);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(84, 27);
            textBox6.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(577, 95);
            label8.Name = "label8";
            label8.Size = new Size(56, 25);
            label8.TabIndex = 10;
            label8.Text = "Price";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(894, 36);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(62, 27);
            textBox5.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(833, 37);
            label7.Name = "label7";
            label7.Size = new Size(58, 25);
            label7.TabIndex = 8;
            label7.Text = "Units";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(393, 93);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(164, 27);
            textBox4.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(310, 95);
            label6.Name = "label6";
            label6.Size = new Size(85, 25);
            label6.TabIndex = 8;
            label6.Text = "Barcode";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(106, 93);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(183, 27);
            textBox3.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(7, 95);
            label5.Name = "label5";
            label5.Size = new Size(97, 25);
            label5.TabIndex = 6;
            label5.Text = "Company";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Tablet", "Capsule", "Injection", "Syrup", "", "Suspension", "", "Solution", "Oral Powder", "", "Effervescent Granules", "Cream", "", "Ointment", "", "Gel", "", "Lotion", "Suppository", "", "Enemas", "Eye Drop", "", "Eye Ointment", "Ear Drop", "", "Ear Ointment" });
            comboBox1.Location = new Point(337, 36);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 28);
            comboBox1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(278, 39);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 4;
            label4.Text = "Form";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(630, 36);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(183, 27);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(501, 37);
            label3.Name = "label3";
            label3.Size = new Size(134, 25);
            label3.TabIndex = 2;
            label3.Text = "Generic name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(72, 37);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(183, 27);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(7, 39);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 0;
            label2.Text = "Name";
            // 
            // salesReturnTab
            // 
            salesReturnTab.Location = new Point(184, 4);
            salesReturnTab.Margin = new Padding(3, 4, 3, 4);
            salesReturnTab.Name = "salesReturnTab";
            salesReturnTab.Size = new Size(1054, 696);
            salesReturnTab.TabIndex = 4;
            salesReturnTab.Text = "Sales Return";
            salesReturnTab.UseVisualStyleBackColor = true;
            // 
            // PurchaseReturnTab
            // 
            PurchaseReturnTab.Location = new Point(184, 4);
            PurchaseReturnTab.Margin = new Padding(3, 4, 3, 4);
            PurchaseReturnTab.Name = "PurchaseReturnTab";
            PurchaseReturnTab.Size = new Size(1054, 696);
            PurchaseReturnTab.TabIndex = 5;
            PurchaseReturnTab.Text = "Purchase Return";
            PurchaseReturnTab.UseVisualStyleBackColor = true;
            // 
            // customersTab
            // 
            customersTab.Controls.Add(dataGridView1);
            customersTab.Controls.Add(groupBox2);
            customersTab.Location = new Point(184, 4);
            customersTab.Margin = new Padding(3, 4, 3, 4);
            customersTab.Name = "customersTab";
            customersTab.Size = new Size(1054, 696);
            customersTab.TabIndex = 8;
            customersTab.Text = "Customers";
            customersTab.UseVisualStyleBackColor = true;
            // 
            // reportsTab
            // 
            reportsTab.Location = new Point(184, 4);
            reportsTab.Margin = new Padding(3, 4, 3, 4);
            reportsTab.Name = "reportsTab";
            reportsTab.Size = new Size(1054, 696);
            reportsTab.TabIndex = 7;
            reportsTab.Text = "Reports";
            reportsTab.UseVisualStyleBackColor = true;
            // 
            // accountTab
            // 
            accountTab.Location = new Point(184, 4);
            accountTab.Margin = new Padding(3, 4, 3, 4);
            accountTab.Name = "accountTab";
            accountTab.Padding = new Padding(3, 4, 3, 4);
            accountTab.Size = new Size(1054, 696);
            accountTab.TabIndex = 0;
            accountTab.Text = "Account";
            accountTab.UseVisualStyleBackColor = true;
            accountTab.Click += tabPage1_Click;
            // 
            // backupTab
            // 
            backupTab.Location = new Point(184, 4);
            backupTab.Margin = new Padding(3, 4, 3, 4);
            backupTab.Name = "backupTab";
            backupTab.Size = new Size(1054, 696);
            backupTab.TabIndex = 6;
            backupTab.Text = "Backup";
            backupTab.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(txtCPhone);
            groupBox2.Controls.Add(txtCAddress);
            groupBox2.Controls.Add(btnSave);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txtCName);
            groupBox2.Controls.Add(label12);
            groupBox2.Location = new Point(24, 28);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(999, 189);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Product";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Green;
            btnSave.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(373, 116);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(116, 41);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(646, 50);
            label9.Name = "label9";
            label9.Size = new Size(106, 25);
            label9.TabIndex = 10;
            label9.Text = "Phone No:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(340, 50);
            label11.Name = "label11";
            label11.Size = new Size(88, 25);
            label11.TabIndex = 8;
            label11.Text = "Address:";
            // 
            // txtCName
            // 
            txtCName.Location = new Point(132, 51);
            txtCName.Margin = new Padding(3, 4, 3, 4);
            txtCName.Name = "txtCName";
            txtCName.Size = new Size(183, 27);
            txtCName.TabIndex = 7;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(57, 50);
            label12.Name = "label12";
            label12.Size = new Size(69, 25);
            label12.TabIndex = 6;
            label12.Text = "Name:";
            // 
            // txtCAddress
            // 
            txtCAddress.Location = new Point(434, 51);
            txtCAddress.Margin = new Padding(3, 4, 3, 4);
            txtCAddress.Name = "txtCAddress";
            txtCAddress.Size = new Size(183, 27);
            txtCAddress.TabIndex = 13;
            // 
            // txtCPhone
            // 
            txtCPhone.Location = new Point(758, 51);
            txtCPhone.Margin = new Padding(3, 4, 3, 4);
            txtCPhone.Name = "txtCPhone";
            txtCPhone.Size = new Size(183, 27);
            txtCPhone.TabIndex = 14;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Green;
            btnUpdate.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(499, 116);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(116, 41);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, phoneNumDataGridViewTextBoxColumn });
            dataGridView1.DataSource = customerBindingSource;
            dataGridView1.Location = new Point(81, 235);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(884, 193);
            dataGridView1.TabIndex = 2;
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(PharmacyManagementSystem.BLL.Models.Customer);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // phoneNumDataGridViewTextBoxColumn
            // 
            phoneNumDataGridViewTextBoxColumn.DataPropertyName = "Phone_Num";
            phoneNumDataGridViewTextBoxColumn.HeaderText = "Phone_Num";
            phoneNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            phoneNumDataGridViewTextBoxColumn.Name = "phoneNumDataGridViewTextBoxColumn";
            // 
            // pms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1242, 781);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
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
            customersTab.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
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
        private GroupBox groupBox2;
        private TextBox txtCPhone;
        private TextBox txtCAddress;
        private Button btnSave;
        private Label label9;
        private Label label11;
        private TextBox txtCName;
        private Label label12;
        private Button btnUpdate;
        private DataGridView dataGridView1;
        private BindingSource customerBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumDataGridViewTextBoxColumn;
    }
}
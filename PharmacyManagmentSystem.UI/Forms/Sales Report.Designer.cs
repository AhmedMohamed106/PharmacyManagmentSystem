namespace PharmacyManagmentSystem.UI.Forms
{
    partial class Sales_Report
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
            groupBox1 = new GroupBox();
            search = new Button();
            label19 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            invoiceNo = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            customer = new DataGridViewTextBoxColumn();
            items = new DataGridViewTextBoxColumn();
            discount = new DataGridViewTextBoxColumn();
            totalPrice = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            drugName = new DataGridViewTextBoxColumn();
            packQt = new DataGridViewTextBoxColumn();
            unitQt = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(search);
            groupBox1.Controls.Add(label19);
            groupBox1.Location = new Point(9, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(779, 78);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select Date";
            // 
            // search
            // 
            search.Location = new Point(644, 28);
            search.Name = "search";
            search.Size = new Size(110, 32);
            search.TabIndex = 15;
            search.Text = "Search";
            search.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label19.Location = new Point(8, 32);
            label19.Name = "label19";
            label19.Size = new Size(83, 20);
            label19.TabIndex = 5;
            label19.Text = "Sales from";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(97, 31);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(328, 33);
            label1.Name = "label1";
            label1.Size = new Size(26, 20);
            label1.TabIndex = 5;
            label1.Text = "To";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(361, 32);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 16;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { invoiceNo, date, customer, items, discount, totalPrice });
            dataGridView1.Location = new Point(9, 101);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(779, 208);
            dataGridView1.TabIndex = 2;
            // 
            // invoiceNo
            // 
            invoiceNo.HeaderText = "Invoice NO.";
            invoiceNo.Name = "invoiceNo";
            invoiceNo.ReadOnly = true;
            // 
            // date
            // 
            date.HeaderText = "Date";
            date.Name = "date";
            date.ReadOnly = true;
            date.Width = 120;
            // 
            // customer
            // 
            customer.HeaderText = "Customer";
            customer.Name = "customer";
            customer.ReadOnly = true;
            customer.Width = 220;
            // 
            // items
            // 
            items.HeaderText = "Items";
            items.Name = "items";
            items.ReadOnly = true;
            // 
            // discount
            // 
            discount.HeaderText = "Discount";
            discount.Name = "discount";
            discount.ReadOnly = true;
            // 
            // totalPrice
            // 
            totalPrice.HeaderText = "Total Price";
            totalPrice.Name = "totalPrice";
            totalPrice.ReadOnly = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { drugName, packQt, unitQt, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dataGridView2.Location = new Point(10, 319);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(779, 187);
            dataGridView2.TabIndex = 3;
            // 
            // drugName
            // 
            drugName.HeaderText = "Drug Name";
            drugName.Name = "drugName";
            drugName.ReadOnly = true;
            drugName.Width = 350;
            // 
            // packQt
            // 
            packQt.HeaderText = "Pack Qt.";
            packQt.Name = "packQt";
            packQt.ReadOnly = true;
            // 
            // unitQt
            // 
            unitQt.HeaderText = "Unit Qt.";
            unitQt.Name = "unitQt";
            unitQt.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Discount";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Total Price";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Sales_Report
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 514);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            MaximumSize = new Size(816, 553);
            MinimumSize = new Size(816, 553);
            Name = "Sales_Report";
            Text = "Sales_Report";
            Load += Sales_Report_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Button search;
        private Label label19;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn invoiceNo;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn customer;
        private DataGridViewTextBoxColumn items;
        private DataGridViewTextBoxColumn discount;
        private DataGridViewTextBoxColumn totalPrice;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn drugName;
        private DataGridViewTextBoxColumn packQt;
        private DataGridViewTextBoxColumn unitQt;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}
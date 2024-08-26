using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmacyManagementSystem.DAL.DataContext;
using PharmacyManagementSystem.BLL.Models;

namespace PharmacyManagmentSystem.UI.Forms
{
    public partial class pms : Form
    {
        public pms()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ApplicationDbContext context = new ApplicationDbContext();
            Customer customer = new Customer()
            {
                Name=this.txtCName.Text,
                Address=this.txtCAddress.Text,
                Phone_Num=this.txtCPhone.Text,
                Email=this.txtCEmail.Text
            };
            context.Customers.Add(customer);
            context.SaveChanges();
            MessageBox.Show("Data Successfully Added");
            this.txtCAddress.Text = "";
            this.txtCName.Text= "";
            this.txtCPhone.Text = "";
            this.txtCEmail.Text = "";
            dgvCustomer.DataSource = context.Customers.ToList();
        }
        
    }
}

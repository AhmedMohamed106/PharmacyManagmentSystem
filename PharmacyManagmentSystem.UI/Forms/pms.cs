using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
using PharmacyManagementSystem.DAL.DataContext;
using PharmacyManagementSystem.BLL.Models;

namespace PharmacyManagmentSystem.UI.Forms
{
    public partial class pms : Form
    {
        public pms()
=======

namespace PharmacyManagmentSystem.UI.Forms
{
    public partial class PMSWindow : Form
    {
        public PMSWindow()
>>>>>>> a88a32a2d4b06f3adecd3a1f3afe21962d156e64
        {
            InitializeComponent();
        }

<<<<<<< HEAD
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
        
=======
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void purchaseTab_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox10_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox12_Enter(object sender, EventArgs e)
        {

        }
>>>>>>> a88a32a2d4b06f3adecd3a1f3afe21962d156e64
    }
}

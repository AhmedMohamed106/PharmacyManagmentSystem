using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagmentSystem.UI.Forms
{
    public partial class PMSWindow : Form
    {
        Sales_Report Sales_Report;
        Purchase_Report purchase_Report;
       
        public PMSWindow()
        {
            InitializeComponent();
        }

        private void saveInvoice_Click(object sender, EventArgs e)
        {
           
        }

        private void salesReport_Click(object sender, EventArgs e)
        {
            Sales_Report = new Sales_Report();
            Sales_Report.ShowDialog();
        }

        private void purchaseReport_Click(object sender, EventArgs e)
        {
            purchase_Report = new Purchase_Report();
            purchase_Report.ShowDialog();
        }
    }
}

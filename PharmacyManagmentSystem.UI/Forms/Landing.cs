using PharmacyManagementSystem.BLL.Services;
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
    public partial class Landing : Form
    {
        private readonly UsersService _userservice;
        public Landing(UsersService userservice)
        {
            InitializeComponent();
            this._userservice = userservice;
        }

       

        private void login_Click_1(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            var mainForm = new PMSWindow(_userservice);
            mainForm.Login(username, password);

            if (mainForm.Visible)
            {
                this.Hide();
            }
        }
    }
}

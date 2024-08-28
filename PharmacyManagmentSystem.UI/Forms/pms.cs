using PharmacyManagementSystem.BLL.Services;
using PharmacyManagementSystem.DAL.Models;
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
        private readonly UsersService _userService;
        private string _userRole;

        public PMSWindow(UsersService usersService)
        {
            InitializeComponent();
            _userService = usersService;
        }

        private void ConfigureTabs()
        {
            guna2TabControl1.TabPages["salesTab"].Enabled = RoleBasedAccess.CanAccess(_userRole, "salesTab");
            guna2TabControl1.TabPages["purchaseTab"].Enabled = RoleBasedAccess.CanAccess(_userRole, "purchaseTab");
            guna2TabControl1.TabPages["customersTab"].Enabled = RoleBasedAccess.CanAccess(_userRole, "customersTab");
            guna2TabControl1.TabPages["reportsTab"].Enabled = RoleBasedAccess.CanAccess(_userRole, "reportsTab");
            guna2TabControl1.TabPages["Stock"].Enabled = RoleBasedAccess.CanAccess(_userRole, "Stock");
            guna2TabControl1.TabPages["addNewProduct"].Enabled = RoleBasedAccess.CanAccess(_userRole, "addNewProduct");
            guna2TabControl1.TabPages["accountTab"].Enabled = RoleBasedAccess.CanAccess(_userRole, "accountTab");
            guna2TabControl1.TabPages["supplierTap"].Enabled = RoleBasedAccess.CanAccess(_userRole, "supplierTap");  //supplier
            
        }

        public void Login(string username, string password)
        {
            var user = _userService.AuthenticateUser(username, password);
            if (user == null)
            {
                MessageBox.Show("Invalid credentials or inactive user.");
                return;
            }

            _userRole = user.Role;
            ConfigureTabs();
            this.Show();
        }

    }
}

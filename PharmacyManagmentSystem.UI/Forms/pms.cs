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
using PharmacyManagementSystem.DAL.DataContext;
using PharmacyManagementSystem.BLL.Services;
using static System.Runtime.InteropServices.JavaScript.JSType;
using PharmacyManagementSystem.DAL.Models;
using System.Net;
using System.Text.RegularExpressions;

namespace PharmacyManagmentSystem.UI.Forms
{
    public partial class PMSWindow : Form
    {
        private string _userRole;

        private CustomerService _customerService;
        private SupplierService _supplierService;
        private UsersService _usersService;
        private SaleItemService saleItemService;
        private PurchaseItemService purchaseItemService;
        private PurchaseService purchaseService;
        private CategoryService categoryService;
        private ProductService productService;
        int _supplierId = 0;
        bool _showpass = true;

        Sales_Report Sales_Report;
        Purchase_Report purchase_Report;

        public PMSWindow(CustomerService customerService, SupplierService supplierService,
            UsersService usersService , SaleItemService saleItemService , PurchaseItemService purchaseItemService
             ,PurchaseService purchaseService , CategoryService categoryService , ProductService productService)
        {
            InitializeComponent();
            _customerService = customerService;
            _supplierService = supplierService;
            _usersService = usersService;
            this.saleItemService = saleItemService;
            this.purchaseItemService = purchaseItemService;
            this.purchaseService = purchaseService;
            this.categoryService = categoryService;
            this.productService = productService;

        }

        //public PMSWindow()
        //{
        //    InitializeComponent();
        //    _customerService = customerService;
        //    _supplierService = supplierService;
        //    _usersService = usersService;
        //}

        //public PMSWindow(UsersService _usersService)
        //{
        //    InitializeComponent();
        //    this._usersService = _usersService;
        //}
        private void SetTabPageAccess(string tabName)
        {
            // Check if the tab exists in the TabPages collection
            if (gtcPharmacy.TabPages.ContainsKey(tabName))
            {
                gtcPharmacy.TabPages[tabName].Enabled = RoleBasedAccess.CanAccess(_userRole, tabName);
            }
            else
            {
                //MessageBox.Show($"Tab '{tabName}' does not exist in the tab control.", "Tab Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ConfigureTabs()
        {
            // Ensure gtcPharmacy is not null
            if (gtcPharmacy == null)
            {
                MessageBox.Show("TabControl is not initialized.");
                return;
            }

            //Loop through all tab pages and configure access

            foreach (TabPage tab in gtcPharmacy.TabPages)
            {
                // Disable all tabs by default
                tab.Enabled = true;



                // Enable only the tabs that the user has access to
                if (!RoleBasedAccess.CanAccess(_userRole, tab.Name))
                {
                    //tab.Enabled = true;

                    gtcPharmacy.TabPages.Remove(tab);

                }
            }



            // Check if _userRole is set
            if (string.IsNullOrEmpty(_userRole))
            {
                MessageBox.Show("User role is not assigned.");
                return;
            }

            // Configure each tab, ensuring the tab exists
            SetTabPageAccess("salesTab");
            SetTabPageAccess("purchaseTab");
            SetTabPageAccess("customersTab");
            SetTabPageAccess("reportsTab");
            SetTabPageAccess("Stock");
            SetTabPageAccess("addNewProduct");
            SetTabPageAccess("accountTab");
            SetTabPageAccess("supplierTap");

        }

        public void Login(string username, string password)
        {
            var user = _usersService.AuthenticateUser(username, password);
            if (user == null)
            {
                MessageBox.Show("Invalid credentials or inactive user.");
                return;
            }



            // Assign the authenticated user's role
            _userRole = user.Role;

            // Ensure _userRole is not null or empty before configuring tabs
            if (string.IsNullOrEmpty(_userRole))
            {
                MessageBox.Show("User role is not set properly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Configure tab access based on the user role
            ConfigureTabs();
            this.Show();
        }



        private void gtcPharmacy_Selected(object sender, TabControlEventArgs e)
        {

            //dgvCustomer.DataSource = null;
            //dgvCustomer.DataSource = _customerService.GetAllCustomers();

            //dgvSupplier.DataSource = null;
            //dgvSupplier.DataSource = _supplierService.GetAllSuppliers();

            //dgvAccounts.DataSource = null;
            //dgvAccounts.DataSource = _usersService.GetAllUsers();


            try
            {
                // Update Customer Data Grid View
                dgvCustomer.DataSource = null;
                var customers = _customerService.GetAllCustomers();
                if (customers != null)
                {
                    dgvCustomer.DataSource = customers;
                }
                else
                {
                    MessageBox.Show("No customer data available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Update Supplier Data Grid View
                dgvSupplier.DataSource = null;
                var suppliers = _supplierService.GetAllSuppliers();
                if (suppliers != null)
                {
                    dgvSupplier.DataSource = suppliers;
                }
                else
                {
                    MessageBox.Show("No supplier data available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Update Accounts Data Grid View
                dgvAccounts.DataSource = null;
                var users = _usersService.GetAllUsers();
                if (users != null)
                {
                    dgvAccounts.DataSource = users;
                }
                else
                {
                    MessageBox.Show("No user data available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Customer
        private void btnCAdd_Click(object sender, EventArgs e)
        {
            string name = this.txtCName.Text.Trim();
            string address = this.txtCAddress.Text.Trim();
            string phoneNum = this.txtCPhone.Text.Trim();
            string email = "";
            var validationMessage = ValidateInput(name, address, phoneNum, email);
            if (!string.IsNullOrEmpty(validationMessage))
            {
                MessageBox.Show(validationMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var check = _customerService.AddCustomer(this.txtCName.Text, this.txtCAddress.Text, this.txtCPhone.Text, "");
            if (check)
            {
                MessageBox.Show("Data Successfully Added");
                this.txtCAddress.Text = "";
                this.txtCName.Text = "";
                this.txtCPhone.Text = "";
                dgvCustomer.DataSource = null;
                dgvCustomer.DataSource = _customerService.GetAllCustomers();
            }
            else
            {
                MessageBox.Show("Duplicate Customer");

            }
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvCustomer.Rows.Count)
            {
                var selectedRow = dgvCustomer.Rows[e.RowIndex].DataBoundItem as Customer;

                if (selectedRow != null)
                {
                    this.txtECID.Text = selectedRow.Id.ToString();
                    this.txtECName.Text = selectedRow.Name.ToString();
                    this.txtECAddress.Text = selectedRow.Address.ToString();
                    this.txtECPhone.Text = selectedRow.Phone_Num.ToString();
                    this.txtECName.ReadOnly = false;
                    this.txtECAddress.ReadOnly = false;
                    this.txtECPhone.ReadOnly = false;
                }
            }
        }

        private void btnCEdit_Click_1(object sender, EventArgs e)
        {
            string name = this.txtECName.Text.Trim();
            string address = this.txtECAddress.Text.Trim();
            string phoneNum = this.txtECPhone.Text.Trim();
            string email = "";

            var validationMessage = ValidateInput(name, address, phoneNum, email);

            if (!string.IsNullOrEmpty(validationMessage))
            {
                MessageBox.Show("Invalid Data", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var customer = _customerService.GetCustomerById(int.Parse(this.txtECID.Text));
            customer.Name = name;
            customer.Address = address;
            customer.Phone_Num = phoneNum;

            var check = _customerService.UpdateCustomer(customer);
            if (check)
            {
                MessageBox.Show("Customer Successfully Updated");
                this.txtECID.Text = "";
                this.txtECAddress.Text = "";
                this.txtECName.Text = "";
                this.txtECPhone.Text = "";
                this.txtECName.ReadOnly = true;
                this.txtECAddress.ReadOnly = true;
                this.txtECPhone.ReadOnly = true;
                dgvCustomer.DataSource = null;
                dgvCustomer.DataSource = _customerService.GetAllCustomers();
            }
            else
            {
                MessageBox.Show("Duplicate Customer");

            }


        }




        private void btnCRemove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtECID.Text))
            {
                MessageBox.Show("Invalid Data", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var check = _customerService.DeleteCustomer(int.Parse(this.txtECID.Text));
            if (check)
            {
                MessageBox.Show("Customer Successfully Deleted");
                this.txtECID.Text = "";
                this.txtECAddress.Text = "";
                this.txtECName.Text = "";
                this.txtECPhone.Text = "";
                this.txtECName.ReadOnly = true;
                this.txtECAddress.ReadOnly = true;
                this.txtECPhone.ReadOnly = true;
                dgvCustomer.DataSource = null;
                dgvCustomer.DataSource = _customerService.GetAllCustomers();
            }
            else
            {
                MessageBox.Show("Duplicate Customer");

            }
        }

        private void btnCSearch_Click(object sender, EventArgs e)
        {
            this.txtECID.Text = "";
            this.txtECAddress.Text = "";
            this.txtECName.Text = "";
            this.txtECPhone.Text = "";
            this.txtECName.ReadOnly = true;
            this.txtECAddress.ReadOnly = true;
            this.txtECPhone.ReadOnly = true;
            string searchTerm = this.txtCSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                dgvCustomer.DataSource = null;
                dgvCustomer.DataSource = _customerService.GetAllCustomers();
                MessageBox.Show("Please enter a search term.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var searchResults = _customerService.SearchCustomers(searchTerm);

            dgvCustomer.DataSource = null;
            dgvCustomer.DataSource = searchResults;

            if (!searchResults.Any())
            {
                MessageBox.Show("No customers found matching the search criteria.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtCSearch_TextChanged(object sender, EventArgs e)
        {
            this.txtECID.Text = "";
            this.txtECAddress.Text = "";
            this.txtECName.Text = "";
            this.txtECPhone.Text = "";
            this.txtECName.ReadOnly = true;
            this.txtECAddress.ReadOnly = true;
            this.txtECPhone.ReadOnly = true;

            string searchTerm = this.txtCSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                dgvCustomer.DataSource = null;
                dgvCustomer.DataSource = _customerService.GetAllCustomers();
                return;
            }

            var searchResults = _customerService.SearchCustomers(searchTerm);

            dgvCustomer.DataSource = null;
            dgvCustomer.DataSource = searchResults;

            if (!searchResults.Any())
            {
            }
        }


        //Supplier
        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            string name = this.txtSuName.Text.Trim();
            string address = this.txtSuAddress.Text.Trim();
            string phoneNum = this.txtSuPhone.Text.Trim();
            string email = this.txtSuEmail.Text.Trim();

            var validationMessage = ValidateInput(name, address, phoneNum, email);
            if (!string.IsNullOrEmpty(validationMessage))
            {
                MessageBox.Show(validationMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var check = _supplierService.AddSupplier(name, address, phoneNum, email);
            if (check)
            {
                MessageBox.Show("Data Successfully Added");
                this.txtCAddress.Text = "";
                this.txtCName.Text = "";
                this.txtCPhone.Text = "";
                dgvSupplier.DataSource = null;
                dgvSupplier.DataSource = _supplierService.GetAllSuppliers();
            }
            else
            {
                MessageBox.Show("Duplicate Supplier");

            }
        }

        private void btnSuEdit_Click(object sender, EventArgs e)
        {
            string name = this.txtESuName.Text.Trim();
            string address = this.txtESuAddress.Text.Trim();
            string phoneNum = this.txtESuPhone.Text.Trim();
            string email = this.txtESuEmail.Text.Trim();

            var validationMessage = ValidateInput(name, address, phoneNum, email);

            if (_supplierId == 0)
            {
                MessageBox.Show("Invalid Data", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var suppler = _supplierService.GetSupplierById(_supplierId);
            suppler.Name = name;
            suppler.Address = address;
            suppler.Phone_Num = phoneNum;
            suppler.Email = email;


            var check = _supplierService.UpdateSupplier(suppler);
            if (check)
            {
                MessageBox.Show("Suppler Successfully Updated");
                this.txtSuAddress.Text = "";
                this.txtSuEmail.Text = "";
                this.txtSuName.Text = "";
                this.txtSuPhone.Text = "";
                this.txtESuName.ReadOnly = true;
                this.txtESuAddress.ReadOnly = true;
                this.txtESuPhone.ReadOnly = true;
                this.txtESuEmail.ReadOnly = true;
                _supplierId = 0;
                dgvSupplier.DataSource = null;
                dgvSupplier.DataSource = _supplierService.GetAllSuppliers();
            }
        }
        private void salesReport_Click(object sender, EventArgs e)
        {
            Sales_Report = new Sales_Report();
            Sales_Report.ShowDialog();
        }

        private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvSupplier.Rows.Count)
            {
                var selectedRow = dgvSupplier.Rows[e.RowIndex].DataBoundItem as Supplier;

                if (selectedRow != null)
                {
                    _supplierId = selectedRow.Id;
                    this.txtESuEmail.Text = selectedRow.Email.ToString();
                    this.txtESuName.Text = selectedRow.Name.ToString();
                    this.txtESuAddress.Text = selectedRow.Address.ToString();
                    this.txtESuPhone.Text = selectedRow.Phone_Num.ToString();

                    this.txtESuName.ReadOnly = false;
                    this.txtESuAddress.ReadOnly = false;
                    this.txtESuPhone.ReadOnly = false;
                    this.txtESuEmail.ReadOnly = false;
                }
            }
        }

        private void btnSuRemove_Click(object sender, EventArgs e)
        {
            if (_supplierId == 0)
            {
                MessageBox.Show("Invalid Data", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var check = _supplierService.DeleteSupplier(_supplierId);
            if (check)
            {
                MessageBox.Show("Suppler Successfully Deleted");
                this.txtESuEmail.Text = "";
                this.txtESuName.Text = "";
                this.txtESuPhone.Text = "";
                this.txtESuAddress.Text = "";
                this.txtESuName.ReadOnly = true;
                this.txtESuAddress.ReadOnly = true;
                this.txtESuPhone.ReadOnly = true;
                this.txtESuEmail.ReadOnly = true;
                _supplierId = 0;
                dgvSupplier.DataSource = null;
                dgvSupplier.DataSource = _supplierService.GetAllSuppliers();
            }
        }

        private void btnSuSearch_Click(object sender, EventArgs e)
        {
            _supplierId = 0;
            this.txtESuAddress.Text = "";
            this.txtESuName.Text = "";
            this.txtESuPhone.Text = "";
            this.txtESuEmail.Text = "";
            this.txtESuName.ReadOnly = true;
            this.txtESuAddress.ReadOnly = true;
            this.txtESuPhone.ReadOnly = true;
            this.txtESuEmail.ReadOnly = true;
            string searchTerm = this.txtSuSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                dgvSupplier.DataSource = null;
                dgvSupplier.DataSource = _supplierService.GetAllSuppliers();
                MessageBox.Show("Please enter a search term.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var searchResults = _supplierService.SearchSupplier(searchTerm);

            dgvSupplier.DataSource = null;
            dgvSupplier.DataSource = searchResults;

            if (!searchResults.Any())
            {
                MessageBox.Show("No suppler found matching the search criteria.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSuSearch_TextChanged(object sender, EventArgs e)
        {
            _supplierId = 0;
            this.txtESuAddress.Text = "";
            this.txtESuName.Text = "";
            this.txtESuPhone.Text = "";
            this.txtESuEmail.Text = "";
            this.txtESuName.ReadOnly = true;
            this.txtESuAddress.ReadOnly = true;
            this.txtESuPhone.ReadOnly = true;
            this.txtESuEmail.ReadOnly = true;
            string searchTerm = this.txtSuSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                dgvSupplier.DataSource = null;
                dgvSupplier.DataSource = _supplierService.GetAllSuppliers();
                return;
            }

            var searchResults = _supplierService.SearchSupplier(searchTerm);

            dgvSupplier.DataSource = null;
            dgvSupplier.DataSource = searchResults;

            if (!searchResults.Any())
            {
            }
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtAcUserName.Text.Trim();
                string password = txtAcPassword.Text.Trim();
                string selectedRole = itemAcRole.SelectedItem?.ToString();

                if (string.IsNullOrWhiteSpace(username))
                {
                    MessageBox.Show("Username is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Password is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string passwordPattern = @"^(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{6,}$";
                if (!Regex.IsMatch(password, passwordPattern))
                {
                    MessageBox.Show("Password must be at least 6 characters long, including one uppercase letter, one number, and one special character.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(selectedRole))
                {
                    MessageBox.Show("Please select a role.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var check = _usersService.AddUser(username, password, selectedRole, true);
                if (check)
                {
                    MessageBox.Show("User successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAcUserName.Text = "";
                    txtAcPassword.Text = "";
                    itemAcRole.SelectedIndex = -1;
                    dgvAccounts.DataSource = null;
                    dgvAccounts.DataSource = _usersService.GetAllUsers();
                }
                else
                {
                    MessageBox.Show("Failed to add user. Possibly a duplicate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ValidateInput(string name, string address, string phoneNum, string email)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return "Supplier name is required.";
            }
            if (string.IsNullOrWhiteSpace(address))
            {
                return "Supplier address is required.";
            }
            if (string.IsNullOrWhiteSpace(phoneNum))
            {
                return "Supplier phone number is required.";
            }
            if (!long.TryParse(phoneNum, out _) || phoneNum.Length != 11)
            {
                return "Phone number must be numeric and exactly 11 digits.";
            }
            if (!string.IsNullOrWhiteSpace(email) && !IsValidEmail(email))
            {
                return "Invalid email format.";
            }
            return string.Empty;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void label27_Click(object sender, EventArgs e)
        {
            if (_showpass)
            {
                this.txtAcPassword.UseSystemPasswordChar = false;
                this.label27.Text = "Hide";
                _showpass = false;
            }
            else
            {
                this.txtAcPassword.UseSystemPasswordChar = true;
                this.label27.Text = "Show";
                _showpass = true;
            }
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            Landing LD = new(_usersService, _customerService, _supplierService , saleItemService
                , purchaseItemService , purchaseService , categoryService , productService);

            LD.Show();
            this.Hide();


        }

        private void purchaseReport_Click(object sender, EventArgs e)
        {
            purchase_Report = new Purchase_Report();
            purchase_Report.ShowDialog();
        }
    }
}


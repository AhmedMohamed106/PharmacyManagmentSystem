using PharmacyManagementSystem.BLL.Services;
using PharmacyManagementSystem.DAL.Models;

namespace PharmacyManagmentSystem.UI.Forms
{
    public partial class PMSWindow : Form
    {
        private ProductService _productService;
        private CategoryService _categoryService;
        public PMSWindow(ProductService productService, CategoryService categoryService)
        {
            InitializeComponent();
            _productService = productService;

            _categoryService = categoryService;

            comboBox1.DisplayMember = "Name";

            comboBox1.ValueMember = "Id";

            comboBox1.DataSource = _categoryService.GetAllCategories();
        }

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

        private void save_Click(object sender, EventArgs e)
        {

        }

        private void guna2TabControl1_Selected(object sender, TabControlEventArgs e)
        {
            var data = _productService.GetAllProducts().ToList();
            dataGridView2.DataSource = data;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {


            var newProduct = _productService.AddProduct(textBox1.Text, textBox2.Text, textBox38.Text, int.Parse(textBox5.Text), DateTime.Today, textBox3.Text, textBox4.Text, int.Parse(textBox6.Text), comboBox1.SelectedIndex);

            if (newProduct == true)
            {
                MessageBox.Show("Product Added Successfully");

                //var product = from products
                //              in _productService.GetAllProducts().ToList()
                //              select products;


                dataGridView1.DataSource = null;
                dataGridView1.DataSource = _productService.GetAllProducts();
            }
            else
            {
                MessageBox.Show("Failed to Add Product");
            }

        }

        private void search_Click(object sender, EventArgs e)
        {
            var data = from Product  in _productService.GetAllProducts()
                       where Product.Name == textBox12.Text || Product.Generic_Name == textBox11.Text || Product.Company == textBox10.Text
                       select Product;


            dataGridView2.DataSource = data.ToList();
        }
    }
}




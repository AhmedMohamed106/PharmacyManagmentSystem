<<<<<<< HEAD
using PharmacyManagmentSystem.UI.Forms;
=======
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.ApplicationServices;
using PharmacyManagementSystem.BLL.Services;
using PharmacyManagementSystem.DAL.DataContext;
using PharmacyManagementSystem.DAL.Repository.IRepository;

using PharmacyManagmentSystem.UI.Forms;

>>>>>>> a88a32a2d4b06f3adecd3a1f3afe21962d156e64
namespace PharmacyManagmentSystem.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
<<<<<<< HEAD
            Application.Run(new pms());
=======

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);

            using (var context = services.BuildServiceProvider())
            {
                var mainform = context.GetRequiredService<PMSWindow>();
                Application.Run(mainform);
            }


        }

        private static void ConfigureServices(ServiceCollection services)
        {
            // Register the ApplicationDbContext
            services.AddScoped<ApplicationDbContext>();

            // Register the Unit of Work
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            // Register services
            services.AddScoped<ProductService>();
            services.AddScoped<CategoryService>();
            services.AddScoped<CustomerService>();
            services.AddScoped<SaleService>();
            services.AddScoped<PurchaseService>();
            services.AddScoped<SupplierService>();
            services.AddScoped<SaleItemService>();
            services.AddScoped<PurchaseItemService>();
            services.AddScoped<UsersService>();

            // Register the forms
            services.AddTransient<PMSWindow>(); // Assuming Form1 is the main form
            // You can add other forms here as needed
            // services.AddTransient<OtherForm>();
>>>>>>> a88a32a2d4b06f3adecd3a1f3afe21962d156e64
        }
    }
}
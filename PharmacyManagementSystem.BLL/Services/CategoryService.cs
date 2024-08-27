using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using PharmacyManagementSystem.DAL.DataContext;
using PharmacyManagementSystem.DAL.Models;
using PharmacyManagementSystem.DAL.Repository.IRepository;

namespace PharmacyManagementSystem.BLL.Services
{
    public class CategoryService
    {
        private readonly IUnitOfWork unit;


        public void AddNewProduct(Product product)
        {

            unit.productRepository.Add(product);

        }

    }
}

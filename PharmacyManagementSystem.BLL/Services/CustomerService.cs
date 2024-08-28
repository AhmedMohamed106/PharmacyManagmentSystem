using PharmacyManagementSystem.DAL.Models;
using PharmacyManagementSystem.DAL.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagementSystem.BLL.Services
{
    public class CustomerService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CustomerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public bool AddCustomer(string name, string address, string phoneNum, string email)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phoneNum) || string.IsNullOrWhiteSpace(email))
            {
                return false;
            }

            Customer customer = new Customer
            {
                Name = name,
                Address = address,
                Phone_Num = phoneNum,
                Email = email
            };

            _unitOfWork.customerRepository.Add(customer);
            _unitOfWork.Save();

            return true;
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _unitOfWork.customerRepository.GetAll(); // Assuming no navigation properties to include
        }

        public Customer GetCustomerById(int id)
        {
            return _unitOfWork.customerRepository.Get(cust => cust.Id == id);
        }

        public bool UpdateCustomer(Customer customer)
        {
            if (customer == null || string.IsNullOrWhiteSpace(customer.Name))
            {
                return false;
            }

            _unitOfWork.customerRepository.Update(customer);
            _unitOfWork.Save();

            return true;
        }

        public bool DeleteCustomer(int id)
        {
            var customer = _unitOfWork.customerRepository.Get(cust => cust.Id == id);
            if (customer == null)
            {
                return false;
            }

            _unitOfWork.customerRepository.Remove(customer);
            _unitOfWork.Save();

            return true;
        }
    }
}

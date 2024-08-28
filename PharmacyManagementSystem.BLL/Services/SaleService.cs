using PharmacyManagementSystem.DAL.Models;
using PharmacyManagementSystem.DAL.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagementSystem.BLL.Services
{
    public class SaleService
    {
        private readonly IUnitOfWork _unitOfWork;

        public SaleService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public bool AddSale(int customerId, DateTime saleDate)
        {
            if (customerId <= 0 || saleDate == default)
            {
                return false;
            }

            var sale = new Sale
            {
                Customer_ID = customerId,
                Sale_Date = saleDate
            };

            try
            {
                _unitOfWork.saleRepository.Add(sale);
                _unitOfWork.Save();
                return true;
            }
            catch (Exception ex)
            {
                // Log exception
                return false;
            }
        }

        public IEnumerable<Sale> GetAllSales()
        {
            try
            {
                return _unitOfWork.saleRepository.GetAll(includeProperties: "Customer,SaleItems").ToList();
            }
            catch (Exception ex)
            {
                // Log exception
                return Enumerable.Empty<Sale>();
            }
        }

        public Sale GetSaleById(int id)
        {
            if (id <= 0)
            {
                return null;
            }

            try
            {
                return _unitOfWork.saleRepository.Get(s => s.Id == id, includeProperties: "Customer,SaleItems");
            }
            catch (Exception ex)
            {
                // Log exception
                return null;
            }
        }

        public bool UpdateSale(Sale sale)
        {
            if (sale == null || sale.Id <= 0)
            {
                return false;
            }

            try
            {
                var existingSale = _unitOfWork.saleRepository.Get(s => s.Id == sale.Id, includeProperties: "SaleItems");
                if (existingSale == null)
                {
                    return false;
                }

                existingSale.Customer_ID = sale.Customer_ID;
                existingSale.Sale_Date = sale.Sale_Date;

                _unitOfWork.saleRepository.Update(existingSale);
                _unitOfWork.Save();

                return true;
            }
            catch (Exception ex)
            {
                // Log exception
                return false;
            }
        }

        public bool DeleteSale(int id)
        {
            if (id <= 0)
            {
                return false;
            }

            try
            {
                var sale = _unitOfWork.saleRepository.Get(s => s.Id == id, includeProperties: "SaleItems");
                if (sale == null)
                {
                    return false;
                }

                _unitOfWork.saleRepository.Remove(sale);
                _unitOfWork.Save();

                return true;
            }
            catch (Exception ex)
            {
                // Log exception
                return false;
            }
        }
    }
}

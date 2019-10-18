using BusinessLayer.Services;
using DataLayer.Models;
using DataLayer.UOW;
using System;
using System.Linq;

namespace BusinessLayer.Service
{
    public class ProductService : IProductService, IDisposable
    {
        private IUnitOfWork _unitOfWork;
        public ProductService(IUnitOfWork unit)
        {
            _unitOfWork = unit;
        }
        public IQueryable<Product> GetAll()
        {
            return _unitOfWork.ProductRepository.GetAll();
        }

        public void Dispose()
        {
            _unitOfWork.Dispose();
        }
    }
}

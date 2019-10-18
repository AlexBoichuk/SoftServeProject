using DataLayer.Models;
using System;
using System.Linq;


namespace BusinessLayer.Services
{
    public interface IProductService : IDisposable
    {
        IQueryable<Product> GetAll();
    }
}

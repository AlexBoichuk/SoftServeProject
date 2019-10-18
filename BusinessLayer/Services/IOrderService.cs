using DataLayer.Models;
using System;
using System.Linq;


namespace BusinessLayer.Services
{
    public interface IOrderService : IDisposable
    {
        IQueryable<Order> GetAllOrders(string userId);
        Order GetBasket(string userId);
        void Buy(int id, string userId);
        void AddProduct(int productId, int quanitity, string userId);
    }
}

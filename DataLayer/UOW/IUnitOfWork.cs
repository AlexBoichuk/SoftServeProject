using DataLayer.Models;
using DataLayer.Repositories;
using System;


namespace DataLayer.UOW
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
        GenericRepository<Product> ProductRepository { get; }
        GenericRepository<Order> OrderRepository { get; }
        GenericRepository<OrderDetail> OrderDetailRepository { get; }
        GenericRepository<User> UserRepository { get; }
    }
}

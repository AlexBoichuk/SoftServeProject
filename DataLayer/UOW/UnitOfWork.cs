using DataLayer.Models;
using DataLayer.Repositories;
using System;


namespace DataLayer.UOW
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private ShopContext _db;
        public UnitOfWork(ShopContext context)
        {
            _db = context;
        }

        private GenericRepository<Product> productRepository;
        private GenericRepository<Order> orderRepository;
        private GenericRepository<OrderDetail> orderDetailRepository;
        private GenericRepository<User> userRepository;

        public GenericRepository<Product> ProductRepository
        {
            get
            {
                if (productRepository == null)
                    productRepository = new GenericRepository<Product>(_db);
                return productRepository;
            }
        }

        public GenericRepository<Order> OrderRepository
        {
            get
            {
                if (orderRepository == null)
                    orderRepository = new GenericRepository<Order>(_db);
                return orderRepository;
            }
        }

        public GenericRepository<OrderDetail> OrderDetailRepository
        {
            get
            {
                if (orderDetailRepository == null)
                    orderDetailRepository = new GenericRepository<OrderDetail>(_db);
                return orderDetailRepository;
            }
        }

        public GenericRepository<User> UserRepository
        {
            get
            {
                if (userRepository == null)
                    userRepository = new GenericRepository<User>(_db);
                return userRepository;
            }
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}

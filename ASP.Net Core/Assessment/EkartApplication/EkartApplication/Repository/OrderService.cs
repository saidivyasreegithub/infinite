using EkartApplication.Models;
using System.Linq;
using System;

namespace EkartApplication.Repository
{
    public class OrderService : IOrderRepository
    {
        private readonly NorthwinddbContext _context;

        public OrderService(NorthwinddbContext context)
        {
            _context = context;
        }

        public Order GetOrderById(int orderId)
        {
            return _context.Orders.FirstOrDefault(o => o.OrderId == orderId);
        }

        public void PlaceOrder(Order order)
        {
           
                _context.Orders.Add(order);
                _context.SaveChanges();
            

        }


        
    }
}

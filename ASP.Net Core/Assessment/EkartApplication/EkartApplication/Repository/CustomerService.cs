using EkartApplication.Models;
using System.Linq;
using System;

namespace EkartApplication.Repository
{
    public class CustomerService
    {
        private readonly NorthwinddbContext _context;

        public CustomerService(NorthwinddbContext context)
        {
            _context = context;
        }

        public Customer GetCustomerById(string customerId)
        {
            return _context.Customers.FirstOrDefault(c => c.CustomerId == customerId);
        }
        public IEnumerable<Customer> GetAllCustomers()
        {
            return _context.Customers.ToList();
        }
        public IEnumerable<Customer> GetCustomersByOrderDate(DateTime orderDate)
        {
            return _context.Customers
                .Where(c => c.Orders.Any(o => o.OrderDate.HasValue && o.OrderDate.Value.Date == orderDate.Date))
                .ToList();
        }

        public Customer GetCustomerWithHighestOrder()
        {
            return _context.Customers.OrderByDescending(c => c.Orders.Sum(o => o.Total)).FirstOrDefault();
        }
    }
}

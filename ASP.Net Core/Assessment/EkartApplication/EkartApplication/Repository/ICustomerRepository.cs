using EkartApplication.Models;

namespace EkartApplication.Repository
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetCustomersByOrderDate(DateTime orderDate);
        Customer GetCustomerWithHighestOrder();
        IEnumerable<Customer> GetAllCustomers();
        Customer GetCustomerById(string customerId);
           
        
    }
}

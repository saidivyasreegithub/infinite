using EkartApplication.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EkartApplication.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

       
        public IActionResult Index()
        {
            return View();
        }
       
            
            public IActionResult Details(string id)
            {
                var customer = _customerRepository.GetCustomerById(id);

                if (customer == null)
                {
                    return NotFound();
                }

                return View(customer);
            }

            public IActionResult CustomersByOrderDate(DateTime orderDate)
            {
                var customers = _customerRepository.GetCustomersByOrderDate(orderDate);
                return View(customers);
            }

            public IActionResult HighestOrderCustomer()
            {
                var customer = _customerRepository.GetCustomerWithHighestOrder();

                if (customer == null)
                {
                    return NotFound();
                }

                return View(customer);
            }
    }

}


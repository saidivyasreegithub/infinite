using EkartApplication.Models;
using EkartApplication.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EkartApplication.Controllers
{
    public class OrderController : Controller
    {
       
            private readonly IOrderRepository _orderRepository;

            public OrderController(IOrderRepository orderRepository)
            {
                _orderRepository = orderRepository;
            }

            [HttpPost]
           
        public IActionResult OrderDetails(int orderId)
        {
            var order = _orderRepository.GetOrderById(orderId);
            return View(order);
        }
        public IActionResult GenerateBill(int orderId)
        {
            var order = _orderRepository.GetOrderById(orderId);
            // Generate bill logic
            return View(order);
        }
        public IActionResult Details(int id)
        {
            var order = _orderRepository.GetOrderById(id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PlaceOrder()
        {
            
            return View();
        }


        [HttpPost]
        public IActionResult PlaceOrder(Order order)
        {
            if (ModelState.IsValid)
            {
                _orderRepository.PlaceOrder(order);
                return RedirectToAction("Index", "Home");
            }
            return View(order);
        }
        
    }
}

using EkartApplication.Models;

namespace EkartApplication.Repository
{
    public interface IOrderRepository
    {
        void PlaceOrder(Order order);
        Order GetOrderById(int orderId);

    }
}

        


        
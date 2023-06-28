using PhuongNH_SE150997_BikeShop.Models;

namespace PhuongNH_SE150997_BikeShop.Services.OrderItemService
{
    public interface IOrderItemService
    {
        List<OrderItem> GetAllOrderItem();
        int GetOrderItemCount();
    }
}

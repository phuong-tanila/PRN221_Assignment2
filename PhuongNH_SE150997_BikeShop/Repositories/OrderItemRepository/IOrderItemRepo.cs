using PhuongNH_SE150997_BikeShop.Models;

namespace PhuongNH_SE150997_BikeShop.Repositories.OrderItemRepository
{
    public interface IOrderItemRepo
    {
        List<OrderItem> GetAll();
        int CountOrderItem();
    }
}

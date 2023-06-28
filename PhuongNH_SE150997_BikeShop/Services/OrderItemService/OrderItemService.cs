using PhuongNH_SE150997_BikeShop.Models;
using PhuongNH_SE150997_BikeShop.Repositories.OrderItemRepository;

namespace PhuongNH_SE150997_BikeShop.Services.OrderItemService
{
    public class OrderItemService : IOrderItemService
    {
        private IOrderItemRepo _orderItemRepository { get; set; }
        public OrderItemService(IOrderItemRepo repository)
        {
            _orderItemRepository = repository;
        }
        public List<OrderItem> GetAllOrderItem()
        {
            return _orderItemRepository.GetAll();
        }

        public int GetOrderItemCount()
        {
            return _orderItemRepository.CountOrderItem();
        }
    }
}

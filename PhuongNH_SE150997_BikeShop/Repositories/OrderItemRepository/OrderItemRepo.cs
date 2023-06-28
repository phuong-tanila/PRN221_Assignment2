using PhuongNH_SE150997_BikeShop.Models;

namespace PhuongNH_SE150997_BikeShop.Repositories.OrderItemRepository
{
    public class OrderItemRepo : RepositoryBase, IOrderItemRepo
    {
        public OrderItemRepo(BikeShopContext context) : base(context)
        {
        }

        public int CountOrderItem()
        {
            return _context.OrderItems.Count();
        }

        public List<OrderItem> GetAll()
        {
            return _context.OrderItems.ToList();
        }
    }
}

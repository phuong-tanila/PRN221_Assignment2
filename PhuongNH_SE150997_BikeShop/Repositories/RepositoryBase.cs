using PhuongNH_SE150997_BikeShop.Models;

namespace PhuongNH_SE150997_BikeShop.Repositories
{
    public abstract class RepositoryBase
    {
        protected readonly BikeShopContext _context;
        public RepositoryBase(BikeShopContext context)
        {
            _context = context;
        }
    }
}

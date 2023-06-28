using PhuongNH_SE150997_BikeShop.Models;

namespace PhuongNH_SE150997_BikeShop.Repositories.ProductRepository
{
    public interface IProductRepo
    {
        Product Create(Product product);
        Product Update(Product product);
        void Delete(int id);
        List<Product> GetAll();
        Product GetById(int id);
        int CountProduct();
    }
}

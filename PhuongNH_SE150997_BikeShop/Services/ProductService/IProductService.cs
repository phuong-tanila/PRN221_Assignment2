using PhuongNH_SE150997_BikeShop.Models;

namespace PhuongNH_SE150997_BikeShop.Services.ProductService
{
    public interface IProductService
    {
        List<Product> GetAllProduct();
        int GetProductCount();
        Product CreateNewProduct(Product product);
        Product UpdateProduct(Product product);
        void DeleteProduct(int id);
    }
}

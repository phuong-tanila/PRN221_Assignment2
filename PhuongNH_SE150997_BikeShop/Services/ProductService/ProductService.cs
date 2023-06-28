using PhuongNH_SE150997_BikeShop.Models;
using PhuongNH_SE150997_BikeShop.Repositories.ProductRepository;
using PhuongNH_SE150997_BikeShop.Repositories.StaffRepository;

namespace PhuongNH_SE150997_BikeShop.Services.ProductService
{
    public class ProductService : IProductService
    {
        private IProductRepo _productRepository { get; set; }
        public ProductService(IProductRepo repository)
        {
            _productRepository = repository;
        }
        public List<Product> GetAllProduct()
        {
            return _productRepository.GetAll();
        }

        public int GetProductCount()
        {
            return _productRepository.CountProduct();
        }

        public Product CreateNewProduct(Product product)
        {
            return _productRepository.Create(product);
        }

        public Product UpdateProduct(Product product)
        {
            return _productRepository.Update(product);
        }

        public void DeleteProduct(int id)
        {
            _productRepository.Delete(id);
        }
    }
}

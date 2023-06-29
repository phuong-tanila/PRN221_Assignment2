using Microsoft.EntityFrameworkCore;
using PhuongNH_SE150997_BikeShop.Models;
using System.Linq;

namespace PhuongNH_SE150997_BikeShop.Repositories.ProductRepository
{
    public class ProductRepo : RepositoryBase, IProductRepo
    {
        public ProductRepo(BikeShopContext context) : base(context)
        {
        }
        public int CountProduct()
        {
            return _context.Products.Count();
        }
        public Product Create(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }

        public void Delete(int id)
        {
            _context.Products.Remove(GetById(id));
            _context.SaveChanges();
        }

        public List<Product> GetAll()
        {
            return _context.Products.Include(p => p.Brand).Include(p => p.Category).ToList();
        }

        public Product GetById(int id)
        {
            return _context.Products.FirstOrDefault(p => p.ProductId == id);
        }

        public Product Update(Product product)
        {
            var result = _context.Products.Update(product).Entity;
            _context.SaveChanges();
            return result;
        }
    }
}

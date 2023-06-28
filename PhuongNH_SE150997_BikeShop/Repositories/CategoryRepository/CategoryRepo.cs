using PhuongNH_SE150997_BikeShop.Models;

namespace PhuongNH_SE150997_BikeShop.Repositories.CategoryRepository
{
    public class CategoryRepo : RepositoryBase, ICategoryRepo
    {
        public CategoryRepo(BikeShopContext context) : base(context)
        {
        }

        public Category Create(Category category)
        {
            var result = _context.Categories.Add(category).Entity;
            _context.SaveChanges();
            return result;
        }

        public void Delete(int id)
        {
            _context.Remove(GetById(id));
        }

        public List<Category> GetAll()
        {
            return _context.Categories.ToList();
        }

        public Category GetById(int id)
        {
            return _context.Categories.FirstOrDefault(c => c.CategoryId == id);
        }

        public Category Update(Category category)
        {
            var result = _context.Categories.Update(category).Entity;
            _context.SaveChanges();
            return result;
        }
    }
}

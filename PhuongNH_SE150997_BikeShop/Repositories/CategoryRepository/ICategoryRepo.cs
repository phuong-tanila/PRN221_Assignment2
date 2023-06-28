using PhuongNH_SE150997_BikeShop.Models;

namespace PhuongNH_SE150997_BikeShop.Repositories.CategoryRepository
{
    public interface ICategoryRepo
    {
        Category Create(Category category);
        Category Update(Category category);
        void Delete(int id);
        Category GetById(int id);
        List<Category> GetAll();
    }
}

using PhuongNH_SE150997_BikeShop.Models;

namespace PhuongNH_SE150997_BikeShop.Services.CategoryService
{
    public interface ICategoryService
    {
        Category Create(Category category);
        Category Update(Category category);
        void Delete(int id);
        Category GetById(int id);
        List<Category> GetAll();
    }
}

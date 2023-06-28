using PhuongNH_SE150997_BikeShop.Models;
using PhuongNH_SE150997_BikeShop.Repositories.BrandRepository;
using PhuongNH_SE150997_BikeShop.Repositories.CategoryRepository;

namespace PhuongNH_SE150997_BikeShop.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepo _categoryRepository { get; set; }
        public CategoryService(ICategoryRepo repository)
        {
            _categoryRepository = repository;
        }
        public Category Create(Category category)
        {
            return _categoryRepository.Create(category);
        }

        public void Delete(int id)
        {
            _categoryRepository.Delete(id);
        }

        public List<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public Category GetById(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public Category Update(Category category)
        {
            return _categoryRepository.Update(category);
        }
    }
}

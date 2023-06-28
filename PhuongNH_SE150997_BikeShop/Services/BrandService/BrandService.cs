using PhuongNH_SE150997_BikeShop.Models;
using PhuongNH_SE150997_BikeShop.Repositories.BrandRepository;
using PhuongNH_SE150997_BikeShop.Repositories.StaffRepository;

namespace PhuongNH_SE150997_BikeShop.Services.BrandService
{
    public class BrandService : IBrandService
    {

        private IBrandRepo _brandRepository { get; set; }
        public BrandService(IBrandRepo repository)
        {
            _brandRepository = repository;
        }
        public Brand Create(Brand brand)
        {
            return _brandRepository.Create(brand);
        }

        public void Delete(int id)
        {
            _brandRepository.Delete(id);
        }

        public List<Brand> GetAll()
        {
            return _brandRepository.GetAll();
        }

        public Brand GetById(int id)
        {
            return _brandRepository.GetById(id);
        }

        public Brand Update(Brand brand)
        {
            return _brandRepository.Update(brand);
        }
    }
}

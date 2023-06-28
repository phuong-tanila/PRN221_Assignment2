using PhuongNH_SE150997_BikeShop.Models;

namespace PhuongNH_SE150997_BikeShop.Repositories.BrandRepository
{
    public interface IBrandRepo
    {
        Brand Create(Brand brand);
        Brand Update(Brand brand);
        void Delete(int id);
        Brand GetById(int id);
        List<Brand> GetAll();
    }
}

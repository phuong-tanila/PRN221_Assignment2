using PhuongNH_SE150997_BikeShop.Models;

namespace PhuongNH_SE150997_BikeShop.Repositories.BrandRepository
{
    public class BrandRepo : RepositoryBase, IBrandRepo
    {
        public BrandRepo(BikeShopContext context) : base(context)
        {
        }

        public Brand Create(Brand brand)
        {
            var result = _context.Brands.Add(brand).Entity;
            _context.SaveChanges();
            return result;
        }

        public void Delete(int id)
        {
            _context.Remove(GetById(id));
            _context.SaveChanges();
        }

        public List<Brand> GetAll()
        {
            return _context.Brands.ToList();
        }

        public Brand GetById(int id)
        {
            return _context.Brands.FirstOrDefault(b => b.BrandId == id);
        }

        public Brand Update(Brand brand)
        {
            var result = _context.Brands.Update(brand).Entity;
            _context.SaveChanges();
            return result;
        }
    }
}

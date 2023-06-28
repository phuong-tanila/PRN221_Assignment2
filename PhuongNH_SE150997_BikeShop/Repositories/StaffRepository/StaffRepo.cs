using PhuongNH_SE150997_BikeShop.Models;

namespace PhuongNH_SE150997_BikeShop.Repositories.StaffRepository
{
    public class StaffRepo : RepositoryBase, IStaffRepo
    {
        public StaffRepo(BikeShopContext context) : base(context)
        {
        }

        public Staff CheckLogin(Staff staff)
        {
            return _context.Staffs.Where(s => s.Email.Equals(staff.Email) && s.Password.Equals(staff.Password)).FirstOrDefault();
        }

        public Staff Create(Staff staff)
        {
            var result = _context.Staffs.Add(staff).Entity;
            _context.SaveChanges();
            return result;
        }

        public void Delete(int id)
        {
            _context.Staffs.Remove(GetById(id));
            _context.SaveChanges();
        }

        public List<Staff> GetAll()
        {
            return _context.Staffs.ToList();
        }

        public Staff GetByEmail(string email)
        {
            return _context.Staffs.FirstOrDefault(u => u.Email.Equals(email));
        }

        public Staff GetById(int id)
        {
            return _context.Staffs.FirstOrDefault(s => s.StaffId == id);
        }

        public List<Staff> SearchByLastName(string lastName)
        {
            return _context.Staffs.Where(s => s.LastName.Contains(lastName)).ToList();
        }

        public Staff Update(Staff staff)
        {
            var result = _context.Staffs.Update(staff).Entity;
            _context.SaveChanges();
            return result;
        }
    }
}

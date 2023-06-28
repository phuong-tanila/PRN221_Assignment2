using PhuongNH_SE150997_BikeShop.Models;

namespace PhuongNH_SE150997_BikeShop.Repositories.StaffRepository
{
    public interface IStaffRepo
    {
        Staff CheckLogin(Staff staff);
        Staff Create(Staff staff);
        Staff Update(Staff staff);
        void Delete(int id);
        Staff GetById(int id);
        Staff GetByEmail(string email);
        List<Staff> GetAll();

        List<Staff> SearchByLastName(string lastName);
    }
}

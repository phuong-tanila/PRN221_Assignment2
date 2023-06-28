using PhuongNH_SE150997_BikeShop.Models;

namespace PhuongNH_SE150997_BikeShop.Services.StaffService
{
    public interface IStaffService
    {
        Staff CheckStaffLogin(Staff staff);
        Staff CreateNewStaff(Staff staff);
        Staff UpdateStaff(Staff staff);
        void DeleteStaff(int id);
        Staff GetStaffById(int id);
        Staff GetStaffByEmail(string email);
        List<Staff> GetAllStaff();

        List<Staff> SearchStaffByLastName(string lastName);
    }
}

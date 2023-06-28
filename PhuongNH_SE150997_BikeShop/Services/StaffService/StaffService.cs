using PhuongNH_SE150997_BikeShop.Models;
using PhuongNH_SE150997_BikeShop.Repositories.StaffRepository;

namespace PhuongNH_SE150997_BikeShop.Services.StaffService
{
    public class StaffService : IStaffService
    {
        private IStaffRepo _staffRepository { get; set; }
        public StaffService(IStaffRepo repository)
        {
            _staffRepository = repository;
        }
        public Staff CheckStaffLogin(Staff staff)
        {
            return _staffRepository.CheckLogin(staff);
        }

        public Staff CreateNewStaff(Staff staff)
        {
            return _staffRepository.Create(staff);
        }

        public void DeleteStaff(int id)
        {
            _staffRepository.Delete(id);
        }

        public List<Staff> GetAllStaff()
        {
            return _staffRepository.GetAll();
        }

        public Staff GetStaffByEmail(string email)
        {
            return _staffRepository.GetByEmail(email);
        }

        public Staff GetStaffById(int id)
        {
            return _staffRepository.GetById(id);
        }

        public List<Staff> SearchStaffByLastName(string lastName)
        {
            return _staffRepository.SearchByLastName(lastName);
        }

        public Staff UpdateStaff(Staff staff)
        {
            return _staffRepository.Update(staff);
        }
    }
}

using PhuongNH_SE150997_BikeShop.Models;
using PhuongNH_SE150997_BikeShop.Repositories.CustomerRepository;
using PhuongNH_SE150997_BikeShop.Repositories.StaffRepository;

namespace PhuongNH_SE150997_BikeShop.Services.CustomerService
{
    public class CustomerService : ICustomerService
    {
        private ICustomerRepo _customerRepository { get; set; }
        public CustomerService(ICustomerRepo repository)
        {
            _customerRepository = repository;
        }
        public List<Customer> GetAllCustomer()
        {
            return _customerRepository.GetAll();
        }

        public int GetCustomerCount()
        {
            return _customerRepository.CountCustomer();
        }
    }
}

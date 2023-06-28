using PhuongNH_SE150997_BikeShop.Models;
using PhuongNH_SE150997_BikeShop.Repositories.CustomerRepository;

namespace PhuongNH_SE150997_BikeShop.Services.CustomerService
{
    public interface ICustomerService
    {
        List<Customer> GetAllCustomer();
        int GetCustomerCount();
    }
}

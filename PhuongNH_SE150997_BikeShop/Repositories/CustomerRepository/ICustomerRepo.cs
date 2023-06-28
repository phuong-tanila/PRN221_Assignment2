using PhuongNH_SE150997_BikeShop.Models;
using System.Numerics;

namespace PhuongNH_SE150997_BikeShop.Repositories.CustomerRepository
{
    public interface ICustomerRepo
    {
        Customer GetById(int id);
        List<Customer> GetAll();
        int CountCustomer();
    }
}

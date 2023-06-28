using PhuongNH_SE150997_BikeShop.Models;

namespace PhuongNH_SE150997_BikeShop.Repositories.CustomerRepository
{
    public class CustomerRepo : RepositoryBase, ICustomerRepo
    {
        public CustomerRepo(BikeShopContext context) : base(context)
        {
        }

        public int CountCustomer()
        {
            return _context.Customers.Count();
        }

        public List<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }

        public Customer GetById(int id)
        {
            return _context.Customers.FirstOrDefault(c => c.CustomerId == id);
        }
    }
}

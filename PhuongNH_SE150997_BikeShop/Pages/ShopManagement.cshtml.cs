using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PhuongNH_SE150997_BikeShop.Models;
using PhuongNH_SE150997_BikeShop.Repositories.StaffRepository;
using PhuongNH_SE150997_BikeShop.Services.BrandService;
using PhuongNH_SE150997_BikeShop.Services.CategoryService;
using PhuongNH_SE150997_BikeShop.Services.CustomerService;
using PhuongNH_SE150997_BikeShop.Services.OrderItemService;
using PhuongNH_SE150997_BikeShop.Services.ProductService;
using PhuongNH_SE150997_BikeShop.Services.StaffService;

namespace PhuongNH_SE150997_BikeShop.Pages
{
    public class ShopManagementModel : PageModel
    {
        private readonly IStaffService _staffService;
        private readonly ICustomerService _customerService;
        private readonly IProductService _productService;
        private readonly IOrderItemService _orderItemService;
        public ShopManagementModel(IStaffService staffService, ICustomerService customerService, IProductService productService, IOrderItemService orderItemService)
        {
            _staffService = staffService;
            _customerService = customerService;
            _productService = productService;
            _orderItemService = orderItemService;
        }

        //[BindProperty]
        //public Models.Brand BrandModel { get; set; } = default;
        //[BindProperty]
        //public Models.Category CategoryModel { get; set; } = default;
        public IList<Product> Product { get; set; } = default;
        public IList<Customer> Customer { get; set; } = default!;
        public IList<Staff> Staff { get; set; } = default!;
        public IList<Brand> Brand { get; set; } = default;
        public int CountCustomer { get; set; } = default;
        public int CountProduct { get; set; } = default;
        public int CountOrderItem { get; set; } = default;
        public void OnGet()
        {
            Product = _productService.GetAllProduct().ToList();
            Staff = _staffService.GetAllStaff().Take(6).ToList();
            CountCustomer = _customerService.GetCustomerCount();
            CountProduct = _productService.GetProductCount();
            CountOrderItem = _orderItemService.GetOrderItemCount();

        }
    }
}

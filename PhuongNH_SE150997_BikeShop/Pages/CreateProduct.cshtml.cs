using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
#nullable disable
using PhuongNH_SE150997_BikeShop.Models;
using PhuongNH_SE150997_BikeShop.Services.BrandService;
using PhuongNH_SE150997_BikeShop.Services.CategoryService;
using PhuongNH_SE150997_BikeShop.Services.ProductService;

namespace PhuongNH_SE150997_BikeShop.Pages
{
    public class CreateProductModel : PageModel
    {
        private readonly IProductService _productService;
        private readonly IBrandService _brandService;
        private readonly ICategoryService _categoryService;
        public CreateProductModel(IProductService productService, IBrandService brandService, ICategoryService categoryService)
        {
            _productService = productService;
            _brandService = brandService;
            _categoryService = categoryService;
        }
        [BindProperty]
        public Models.Product ProductModel { get; set; }
        public IActionResult OnGet()
        {
            ViewData["BrandId"] = new SelectList(_brandService.GetAll(), "BrandId", "BrandName");
            ViewData["CategoryId"] = new SelectList(_categoryService.GetAll(), "CategoryId", "CategoryName");
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid || ProductModel == null)
            {
                ViewData["BrandId"] = new SelectList(_brandService.GetAll(), "BrandId", "BrandName");
                ViewData["CategoryId"] = new SelectList(_categoryService.GetAll(), "CategoryId", "CategoryName");
                return Page();
            }
         

            _productService.CreateNewProduct(ProductModel);
            return RedirectToPage("/ShopManagement");
        }
    }
}

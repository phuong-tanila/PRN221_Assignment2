using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PhuongNH_SE150997_BikeShop.Services.StaffService;
using System.ComponentModel.DataAnnotations;

namespace PhuongNH_SE150997_BikeShop.Pages
{
    public class LoginModel : PageModel
    {
        private readonly IStaffService staffService;

        [BindProperty]
        [EmailAddress]
        public string Email { get; set; }
        [BindProperty]
        public string Password { get; set; }

        public LoginModel(IStaffService staffService)
        {
            this.staffService = staffService;
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                var staff = staffService.CheckStaffLogin(new Models.Staff(Email, Password));
                if (staff != null)
                {
                    HttpContext.Session.SetString("firstname", staff.FirstName);
                    HttpContext.Session.SetString("lastname", staff.LastName);
                    return RedirectToPage("/ShopManagement");
                }
                ViewData["msg"] = "Invalid login credentials, please try again!";
            }
            return Page();
        }
    }
}

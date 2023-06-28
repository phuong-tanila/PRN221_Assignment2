using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;
using PhuongNH_SE150997_BikeShop.Models;
using PhuongNH_SE150997_BikeShop.Repositories.BrandRepository;
using PhuongNH_SE150997_BikeShop.Repositories.CategoryRepository;
using PhuongNH_SE150997_BikeShop.Repositories.CustomerRepository;
using PhuongNH_SE150997_BikeShop.Repositories.OrderItemRepository;
using PhuongNH_SE150997_BikeShop.Repositories.ProductRepository;
using PhuongNH_SE150997_BikeShop.Repositories.StaffRepository;
using PhuongNH_SE150997_BikeShop.Services.BrandService;
using PhuongNH_SE150997_BikeShop.Services.CategoryService;
using PhuongNH_SE150997_BikeShop.Services.CustomerService;
using PhuongNH_SE150997_BikeShop.Services.OrderItemService;
using PhuongNH_SE150997_BikeShop.Services.ProductService;
using PhuongNH_SE150997_BikeShop.Services.StaffService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSession();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddDbContext<BikeShopContext>(options => options.UseSqlServer("name=DefaultConnection"));
builder.Services.AddScoped<BikeShopContext>();
builder.Services.AddScoped<IStaffRepo, StaffRepo>();
builder.Services.AddScoped<IStaffService, StaffService>();
builder.Services.AddScoped<ICustomerRepo, CustomerRepo>();
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<IProductRepo, ProductRepo>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IOrderItemRepo, OrderItemRepo>();
builder.Services.AddScoped<IOrderItemService, OrderItemService>();
builder.Services.AddScoped<IBrandRepo, BrandRepo>();
builder.Services.AddScoped<IBrandService, BrandService>();
builder.Services.AddScoped<ICategoryRepo, CategoryRepo>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseSession();
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();


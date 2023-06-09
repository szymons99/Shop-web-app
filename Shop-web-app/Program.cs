using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Shop_web_app;
using Shop_web_app.Models;
using Shop_web_app.Services;
using Shop_web_app.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IWarehouseService, WarehouseService>();
builder.Services.AddScoped<IApiService, ApiService>();

builder.Services.AddDbContext<DbTestContext>(builder =>
{
    builder.UseSqlServer(@"Data Source=SERVER HERE;Initial Catalog=DbTest;Integrated Security=True;TrustServerCertificate=true");
});

builder.Services.AddIdentity<UserModel, IdentityRole>(options =>
{
    options.Password.RequireDigit = false;
    options.Password.RequiredLength = 2;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
}).AddEntityFrameworkStores<DbTestContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

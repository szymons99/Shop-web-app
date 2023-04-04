using Microsoft.EntityFrameworkCore;
using Shop_web_app;
using Shop_web_app.Services;
using Shop_web_app.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IWarehouseService, WarehouseService>();

builder.Services.AddDbContext<DbTestContext>(builder =>
{
    builder.UseSqlServer(@"Data Source=DESKTOP-E20F6HG\SQLEXPRESS;Initial Catalog=DbTest;Integrated Security=True;TrustServerCertificate=true");
});

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

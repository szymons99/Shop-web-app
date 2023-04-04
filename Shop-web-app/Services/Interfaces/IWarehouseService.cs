using Shop_web_app.Models;

namespace Shop_web_app.Services.Interfaces
{
    public interface IWarehouseService
    {
        int Save(Product product);
        List<Product> GetAll();
    }
}

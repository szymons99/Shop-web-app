using Shop_web_app.Models;
using Shop_web_app.Services.Interfaces;

namespace Shop_web_app.Services
{
    public class WarehouseService : IWarehouseService
    {
        private readonly DbTestContext _context;

        public WarehouseService(DbTestContext context)
        {
            _context = context;
        }

        public List<Product> GetAll()
        {
            var products = _context.Products.ToList();

            return products;
        }

        public int Save(Product product)
        {
            _context.Products.Add(product);
            if(_context.SaveChanges() > 0)
            {
                System.Console.WriteLine("Success");
            };

            return product.Id;
        }
    }
}

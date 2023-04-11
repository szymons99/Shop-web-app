using Shop_web_app.Models;

namespace Shop_web_app.Services.Interfaces
{
    public interface IApiService
    {
        WeatherResponse Get(string city);
    }
}

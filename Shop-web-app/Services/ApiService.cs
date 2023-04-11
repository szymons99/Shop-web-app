using Newtonsoft.Json;
using Shop_web_app.Models;
using Shop_web_app.Services.Interfaces;
using System.Net;

namespace Shop_web_app.Services
{
    public class ApiService : IApiService
    {
        private const string API_KEY = "KEY HERE";
        public WeatherResponse Get(string city)
        {
            var url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={API_KEY}";

            var web = new WebClient();

            var response = web.DownloadString(url);

            var myDeserializedClass = JsonConvert.DeserializeObject<WeatherResponse>(response);

            myDeserializedClass.main.temp_min = myDeserializedClass.main.temp_min - 273.15;
            myDeserializedClass.main.temp_max = myDeserializedClass.main.temp_max - 273.15;

            return myDeserializedClass;
        }
    }
}

using System;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp1.Singleton
{
    public class OpenWeatherHttpClient
    {
        private HttpClient _client { get; }
        private FileWriter _writer { get; };
        
        public OpenWeatherHttpClient(HttpClient client,
            FileWriter writer)
        {
            client.BaseAddress = new Uri("http://api.openweathermap.org");
            client.DefaultRequestHeaders.Add("User-Agent", "Asp.Net-Forecaster");

            _client = client;
            _writer = writer;
        }
        
        public async Task GetLocationWeather(string location)
        {
            var requestUri = "/data/2.5/" +
                             "weather?q=" + location +
                             "&appid=" + "api_key";
            
            var response = await _client.GetAsync(requestUri);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                var deserialized = await JsonSerializer.DeserializeAsync<CityWeather>(responseStream);
                _writer.SaveTopath(deserialized.ToString());
            }
        }
    }
}
using Explorer.MVVM.Model;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Input;
using Weather.MVVM.Models;

namespace Explorer.MVVM.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class WeatherViewModel
    {
        HttpClient client;

        public WeatherData WeatherData { get; set; }

        public string PlaceName { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

        public WeatherViewModel()
        {
            client = new HttpClient();
        }

        public async Task<WeatherResult> GetCoordinate()
        {
            var url = $"https://geocoding-api.open-meteo.com/v1/search?name=Hamedan";

            var response = await client.GetAsync(url);

            WeatherResult weatherResult = null;

            if (response.IsSuccessStatusCode)
            {
                using (var responseStream = await response.Content.ReadAsStreamAsync())
                {
                    weatherResult = await JsonSerializer.DeserializeAsync<WeatherResult>(responseStream);
                }
            }

            return weatherResult;

        }

        public async Task GetWeatherData(WeatherResult result)
        {
            var url = $"https://api.open-meteo.com/v1/forecast?latitude={result.results[0].latitude}&longitude={result.results[0].longitude}&daily=weathercode,temperature_2m_max,temperature_2m_min&current_weather=true&timezone=Asia%2FTokyo";

            var response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                using (var responseStream = await response.Content.ReadAsStreamAsync())
                {
                    var data = await JsonSerializer.DeserializeAsync<WeatherData>(responseStream);

                    WeatherData = data;

                    for(int i=0; i< WeatherData.daily.time.Length; i++)
                    {
                        var daily2 = new Daily2()
                        {
                            time = WeatherData.daily.time[i],
                            temperature_2m_max = WeatherData.daily.temperature_2m_max[i],
                            temperature_2m_min = WeatherData.daily.temperature_2m_min[i],
                            weathercode = WeatherData.daily.weathercode[i]
                        };

                        WeatherData.daily2.Add(daily2);
                    }
                }
            }

        }
    }
}

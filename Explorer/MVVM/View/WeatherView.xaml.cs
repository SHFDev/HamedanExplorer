using Explorer.MVVM.Model;
using Explorer.MVVM.ViewModel;
using Newtonsoft.Json;
using Weather.MVVM.Models;

namespace Explorer.MVVM.Views;

public partial class WeatherView : ContentPage
{
    HttpClient client;

    public WeatherView()
	{
		InitializeComponent();
		BindingContext = this;
        client = new HttpClient();
        FillData();
    }

    public WeatherData WeatherData { get; set; }

    public string PlaceName { get; set; }

    public DateTime Date { get; set; } = DateTime.Now;

    public void FillData()
    {
        var result = GetCoordinate();
        GetWeatherData(result);
    }

    public WeatherResult GetCoordinate()
    {
        //Uri url = new("https://geocoding-api.open-meteo.com/v1/search?name=Hamedan");
        var url = "https://geocoding-api.open-meteo.com/v1/search?name=Hamedan";
        var response = client.GetAsync(url).Result;
        
        WeatherResult weatherResult = null;

        if (response.IsSuccessStatusCode)
        {
            using (var responseStream = response.Content.ReadAsStreamAsync())
            {
                weatherResult = JsonConvert.DeserializeObject<WeatherResult>(response.Content.ReadAsStringAsync().Result);
            }
        }

        return weatherResult;

    }

    public void GetWeatherData(WeatherResult result)
    {
        var url = $"https://api.open-meteo.com/v1/forecast?latitude={result.results[0].latitude}&longitude={result.results[0].longitude}&daily=weathercode,temperature_2m_max,temperature_2m_min&current_weather=true&timezone=Asia%2FTokyo";

        var response = client.GetAsync(url).Result;

        if (response.IsSuccessStatusCode)
        {
            using (var responseStream = response.Content.ReadAsStreamAsync())
            {
                var data = JsonConvert.DeserializeObject<WeatherData>(response.Content.ReadAsStringAsync().Result);

                WeatherData = data;

                for (int i = 0; i < WeatherData.daily.time.Length; i++)
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
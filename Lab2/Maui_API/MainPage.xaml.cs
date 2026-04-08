using API.Data;
using API.Models;
using System.Collections.ObjectModel;
using System.Text.Json;

namespace Maui_API;

public partial class MainPage : ContentPage
{
    private readonly HttpClient client = new();
    private readonly API.Data.db _db = new();
    public System.Collections.ObjectModel.ObservableCollection<API.Models.ToDo> Records { get; set; } = new();

    public MainPage()
    {
        InitializeComponent();
        this.BindingContext = this; 
        WeatherListView.ItemsSource = Records;
        LoadFromDb();
    }

    private void LoadFromDb()
    {
        Records.Clear();
        var data = _db.WeatherRecords.OrderByDescending(w => w.Timestamp).ToList();
        foreach (var item in data) Records.Add(item);
    }

    private async void OnGetWeatherClicked(object sender, EventArgs e)
    {
        string city = CityEntry.Text?.Trim();
        if (string.IsNullOrEmpty(city)) return;
        var existing = _db.WeatherRecords.FirstOrDefault(w => w.CityName.ToLower() == city.ToLower());
        TimeSpan cacheDuration = TimeSpan.FromHours(1);

        if (existing != null)
        {
            if (DateTime.Now - existing.Timestamp < cacheDuration)
            {
                await DisplayAlert("Dane aktualne", $"Pogoda dla {city} była aktualizowana mniej niż godzinę temu.", "OK");
                return;
            }
            else
            {
                _db.WeatherRecords.Remove(existing);
                _db.SaveChanges();
                var toRemove = Records.FirstOrDefault(r => r.CityName.ToLower() == city.ToLower());
                if (toRemove != null) Records.Remove(toRemove);
            }
        }

        try
        {
            string apiKey = "1528a4924964a2877b0ab9022d2c71d8";
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";

            string response = await client.GetStringAsync(url);
            using var json = JsonDocument.Parse(response);
            var root = json.RootElement;

            var newRecord = new ToDo
            {
                CityName = root.GetProperty("name").GetString(),
                Temperature = (float)root.GetProperty("main").GetProperty("temp").GetDouble(),
                Description = root.GetProperty("weather")[0].GetProperty("description").GetString(),
                Humidity = root.GetProperty("main").GetProperty("humidity").GetInt32().ToString(),
                Timestamp = DateTime.Now 
            };

            _db.WeatherRecords.Add(newRecord);
            _db.SaveChanges();
            Records.Insert(0, newRecord);
        }
        catch (Exception)
        {
            await DisplayAlert("Błąd", "Nie udało się zaktualizować danych.", "OK");
        }
    }
}
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Linq;
using System.Text.Json;

namespace API
{
    internal class API
    {
        public HttpClient client;

        public async Task GetData()
        {
            using var db = new WeatherContext(); 
            client = new HttpClient();
            string API_key = "1528a4924964a2877b0ab9022d2c71d8";

            Console.WriteLine("Podaj miasto:");
            string city = Console.ReadLine();
            var existing = db.WeatherRecords.FirstOrDefault(w => w.CityName.ToLower() == city.ToLower());

            if (existing != null)
            {
                Console.WriteLine("Pobrano z bazy danych:");
                Console.WriteLine(existing.ToString());
            }
            else
            {
                string call1 = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={API_key}&units=metric";
                string response = await client.GetStringAsync(call1);

                using var json = JsonDocument.Parse(response);
                var root = json.RootElement;

                ToDo newRecord = new ToDo
                {
                    CityName = root.GetProperty("name").GetString(),
                    Temperature = (float)root.GetProperty("main").GetProperty("temp").GetDouble(),
                    Description = root.GetProperty("weather")[0].GetProperty("description").GetString(),
                    Timestamp = DateTime.Now,
                    Humidity = root.GetProperty("main").GetProperty("humidity").GetInt32().ToString()
                };

                db.WeatherRecords.Add(newRecord);
                db.SaveChanges();

                Console.WriteLine("Pobrano z API i zapisano do bazy:");
                Console.WriteLine(newRecord.ToString());
            }
        }
    }
}
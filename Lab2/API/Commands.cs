using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API
{
    internal class Commands
    {
        public static void ShowDatabase()
        {
            using var db = new WeatherContext();
            var records = db.WeatherRecords.ToList();

            Console.WriteLine("\n--- Zawartość bazy danych ---");
            if (!records.Any())
            {
                Console.WriteLine("Baza jest pusta.");
            }
            else
            {
                foreach (var record in records)
                {
                    Console.WriteLine(record.ToString());
                }
            }
            Console.WriteLine("-----------------------------\n");
        }

        public static void DeleteRecord()
        {
            Console.WriteLine("Podaj miasto do usunięcia:");
            string city = Console.ReadLine();
            if (city is not null)
            {
                using var db = new WeatherContext();
                var record = db.WeatherRecords.FirstOrDefault(x => x.CityName == city);

                if (record != null)
                {
                    db.WeatherRecords.Remove(record);
                    db.SaveChanges();
                    Console.WriteLine($"Usunięto: {city}");
                }
                else
                {
                    Console.WriteLine("Nie znaleziono pozycji o takiej nazwie.");
                }
            }
            else
            {
                Console.WriteLine("Niepoprawna nazwa miasta.");
            }
        }
    }
}
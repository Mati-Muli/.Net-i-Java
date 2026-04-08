using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Loader;
using System.Text;
using System.Threading.Tasks;

namespace API
{
    internal class ToDo
    {
        public int Id { get; set; }
        public required string CityName { get; set; } 
        public float Temperature { get; set; }
        public string? Description { get; set; }
        public DateTime Timestamp { get; set; } 
        public string? Humidity { get; set; } 

        public override string ToString()
        { 
            return $"ID: {Id,-3} | Miasto: {CityName,-15} | Temp: {Temperature:0.0}C | Wilgotność: {Humidity} | Opis: {Description ?? "brak"} | Data: {Timestamp:yyyy-MM-dd HH:mm}";
        }
    }
}

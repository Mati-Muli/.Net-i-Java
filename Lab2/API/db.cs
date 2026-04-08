using Microsoft.EntityFrameworkCore;

namespace API
{
    internal class WeatherContext : DbContext
    {
        public DbSet<ToDo> WeatherRecords { get; set; }

        public WeatherContext()
        {
            Database.EnsureCreated(); 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(@"Data Source=weather.db");
        }
    }
}
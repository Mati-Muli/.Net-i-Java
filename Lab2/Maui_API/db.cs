using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

internal class db : DbContext
{
    public DbSet<ToDo> WeatherRecords { get; set; }

    public db()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        string dbPath = Path.Combine(FileSystem.AppDataDirectory, "weather.db");
        options.UseSqlite($"Data Source={dbPath}");
    }
}
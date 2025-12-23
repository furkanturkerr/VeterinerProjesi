using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrate;

public class VetContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost,1995;Database=VetLife;User Id=sa;Password=Furkan12*;TrustServerCertificate=True;");
    }
    
    public DbSet<Animal> Animals { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<Treatment> Treatments { get; set; }
    public DbSet<WeatherInfo> WeatherInfos { get; set; }
}
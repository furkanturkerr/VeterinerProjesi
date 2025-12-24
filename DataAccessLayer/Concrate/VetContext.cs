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
    
    public DbSet<Footer> Footers  { get; set; }
    public DbSet<UIAppointment> UIAppointments { get; set; }
    public DbSet<Team> Teams { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<About> Abouts { get; set; }
    public DbSet<Hero> Heroes { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<Summary> Summaries { get; set; }
}
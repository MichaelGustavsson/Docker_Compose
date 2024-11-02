using Microsoft.EntityFrameworkCore;
using VehiclesApi.Models;

namespace VehiclesApi.Data;

public class DataContext : DbContext
{
  public DataContext(DbContextOptions options) : base(options) { }

  public DbSet<Vehicle> Vehicles { get; set; }

}

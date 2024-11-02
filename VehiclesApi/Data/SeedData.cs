using AutoFixture;
using VehiclesApi.Models;

namespace VehiclesApi.Data;

public static class SeedData
{
  public static void Seed(this DataContext context)
  {
    if (!context.Vehicles.Any())
    {
      Fixture fixture = new Fixture();
      fixture.Customize<Vehicle>(v => v.Without(c => c.Id));
      List<Vehicle> vehicles = fixture.CreateMany<Vehicle>(10).ToList();
      context.AddRange(vehicles);
      context.SaveChanges();
    }
  }
}

using Microsoft.AspNetCore.Mvc;
using VehiclesApi.Data;

namespace VehiclesApi.Controllers;

[ApiController]
[Route("[Controller]")]
public class VehiclesController : ControllerBase
{
  private readonly DataContext _context;
  public VehiclesController(DataContext context)
  {
    _context = context;
  }

  [HttpGet()]
  public ActionResult GetVehicles()
  {
    return Ok(_context.Vehicles.ToList());
  }
}

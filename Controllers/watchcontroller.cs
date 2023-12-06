// WatchesController.cs
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ClockWorksOrange.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WatchesController : ControllerBase
    {
        private static readonly List<Watch> Watches = new List<Watch>
        {
            new Watch { Id = 1, BrandName = "Brand 1", Description = "Description 1", Type = "Type 1", Price = 100.00 },
            new Watch { Id = 2, BrandName = "Brand 2", Description = "Description 2", Type = "Type 2", Price = 150.00 },
            // Add more watches as needed
        };

        [HttpGet]
        public ActionResult<IEnumerable<Watch>> GetWatches()
        {
            return Ok(Watches);
        }
    }

public class Watch
{
    public int Id { get; set; }
    public string? BrandName { get; set; }
    public string? Description { get; set; }
    public string? Type { get; set; }
    public decimal Price { get; set; }
}

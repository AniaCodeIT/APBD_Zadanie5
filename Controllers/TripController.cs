using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace Zadanie7.Controllers
{
    [Route("api/trips")]
    [ApiController]
    public class TripController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult> GetTrips()
        {
            return Ok();
        }
    }
}

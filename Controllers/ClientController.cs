using Microsoft.AspNetCore.Mvc;

namespace Zadanie7.Controllers
{
    [Route("api/clients")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult> GetStudents()
        {
            return Ok();
        }
    }
}

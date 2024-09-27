using Microsoft.AspNetCore.Mvc;

namespace SumAPI.Controllers
{
    public class MathController : Controller
    {
        [HttpGet("RealizaSoma")]
        public IActionResult Sum([FromQuery] int v1, [FromQuery] int v2)
        {
            int resultado = v1 + v2;

            return Ok(resultado);
        }
    }
}

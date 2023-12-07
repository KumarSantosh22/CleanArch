using DTOs.Request;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StripePaymentsController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> CreatePaymentIntent([FromBody] StripePaymentRequest request)
        {
            return Ok(request);
        }
    }
}

using API.Models;
using DTOs.Response;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using System.Collections.Generic;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private readonly ITicketContract ticketContract;

        public TicketsController(ITicketContract ticketContract)
        {
            this.ticketContract = ticketContract;
        }

        [HttpGet]
        public async Task<ActionResult<APIResponse<IEnumerable<TicketResponseDto>>>> Get()
        {
            try
            {
                IEnumerable<TicketResponseDto> tickets = await ticketContract.GetAll();
                return Ok(APIResponse<IEnumerable<TicketResponseDto>>.Success(tickets));
            }
            catch (Exception ex)
            {
                return BadRequest(APIResponse<IEnumerable<TicketResponseDto>>.Failure(ex.Message));
            }
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

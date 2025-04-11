using HexagonalCrud.Application.Services;
using HexagonalCrud.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace HexagonalCrud.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientsController : ControllerBase
    {
        private readonly ClientService _service;
        public ClientsController(ClientService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Client>>> Get()
        {
            var clients = await _service.GetAllAsync();
            return Ok(clients);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Client>> Get(int id)
        {
            var client = await _service.GetByIdAsync(id);
            if (client == null)
                return NotFound();
            return Ok(client);
        }
        [HttpPost]
        public async Task<ActionResult> Post(Client client)
        {
            await _service.AddAsync(client);
            return CreatedAtAction(nameof(Get), new { id = client.Id }, client);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, Client client)
        {
            if (id != client.Id)
                return BadRequest();
            await _service.UpdateAsync(client);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return NoContent();
        }
    }
}

using BusinessLayer.Clients.Services;
using DataLayer.Clients.Models;
using Microsoft.AspNetCore.Mvc;
using WebApi.monitoring.Errors;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly IClientService _clientService;
        private readonly IErrorHandler _error;

        public ClientsController(
            IClientService clientService,
            IErrorHandler error)
        {
            _clientService = clientService;
            _error = error;
        }

        [HttpPost]
        [ProducesResponseType(500)]
        [ProducesResponseType(503)]
        [ProducesResponseType(204)]
        public async Task<ActionResult<long>> AddNewClient(AddClientRequest request)
        {
            long clientId;
            try
            {
                clientId = await _clientService.AddClient(request);
            }
            catch (Exception ex)
            {
                return StatusCode(500, _error.DefaultHandle(nameof(AddNewClient), ex));
            }

            return Ok(clientId);
        }
    }
}
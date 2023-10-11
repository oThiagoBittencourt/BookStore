using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        // Conexão com o Service do Modelo
        private readonly IClienteService _clienteService;
        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        // Leitura
        [HttpGet]
        public async Task<ActionResult<List<Cliente>>> GetAllClientes()
        {
            return await _clienteService.GetAllClientes();
        }

        // Leitura através do ID
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Cliente>> GetSingleCliente(int id)
        {
            var result = await _clienteService.GetSingleCliente(id);
            if (result is null)
                return NotFound();
            return Ok(result);
        }

        // Criação
        [HttpPost]
        public async Task<ActionResult<List<Cliente>>> AddCliente(Cliente cliente)
        {
            var result = await _clienteService.AddCliente(cliente);
            return Ok(result);
        }

        // Atualização
        [HttpPut]
        [Route("{id}")]
        public async Task<ActionResult<List<Cliente>>> UpdateCliente(int id, Cliente request)
        {
            var result = await _clienteService.UpdateCliente(id, request);
            if (result is null)
                return NotFound();
            return Ok(result);
        }

        // Deletar
        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult<List<Cliente>>> DeleteCliente(int id)
        {
            var result = await _clienteService.DeleteCliente(id);
            if (result is null)
                return NotFound();
            return Ok(result);
        }
    }
}

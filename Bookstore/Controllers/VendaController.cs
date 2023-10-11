using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendaController : ControllerBase
    {
        // Conexão com o Service do Modelo
        private readonly IVendaService _vendaService;
        public VendaController(IVendaService vendaService)
        {
            _vendaService = vendaService;
        }

        // Leitura
        [HttpGet]
        public async Task<ActionResult<List<Venda>>> GetAllVendas()
        {
            return await _vendaService.GetAllVendas();
        }

        // Leitura através do ID
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Venda>> GetSingleVenda(int id)
        {
            var result = await _vendaService.GetSingleVenda(id);
            if (result is null)
                return NotFound();
            return Ok(result);
        }

        // Criação
        [HttpPost]
        public async Task<ActionResult<List<Venda>>> AddVenda(Venda venda)
        {
            var result = await _vendaService.AddVenda(venda);
            return Ok(result);
        }

        // Deletar
        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult<List<Venda>>> DeleteVenda(int id)
        {
            var result = await _vendaService.DeleteVenda(id);
            if (result is null)
                return NotFound();
            return Ok(result);
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        // Conexão com o Service do Modelo
        private readonly IAutorService _autorService;
        public AutorController(IAutorService autorService)
        {
            _autorService = autorService;
        }

        // Leitura
        [HttpGet]
        public async Task<ActionResult<List<Autor>>> GetAllAutores()
        {
            return await _autorService.GetAllAutores();
        }

        // Leitura através do ID
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Autor>> GetSingleAutor(int id)
        {
            var result = await _autorService.GetSingleAutor(id);
            if (result is null)
                return NotFound();
            return Ok(result);
        }

        // Criação
        [HttpPost]
        public async Task<ActionResult<List<Autor>>> AddAutor(Autor autor)
        {
            var result = await _autorService.AddAutor(autor);
            return Ok(result);
        }

        // Atualização
        [HttpPut]
        [Route("{id}")]
        public async Task<ActionResult<List<Autor>>> UpdateAutor(int id, Autor request)
        {
            var result = await _autorService.UpdateAutor(id, request);
            if (result is null)
                return NotFound();
            return Ok(result);
        }

        // Deletar
        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult<List<Autor>>> DeleteAutor(int id)
        {
            var result = await _autorService.DeleteAutor(id);
            if (result is null)
                return NotFound();
            return Ok(result);
        }
    }
}
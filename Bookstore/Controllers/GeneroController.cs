using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneroController : ControllerBase
    {
        // Conexão com o Service do Modelo
        private readonly IGeneroService _generoService;
        public GeneroController(IGeneroService generoService)
        {
            _generoService = generoService;
        }

        // Leitura
        [HttpGet]
        public async Task<ActionResult<List<Genero>>> GetAllGeneros()
        {
            return await _generoService.GetAllGeneros();
        }

        // Leitura através do ID
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Genero>> GetSingleGenero(int id)
        {
            var result = await _generoService.GetSingleGenero(id);
            if (result is null)
                return NotFound();
            return Ok(result);
        }

        // Criação
        [HttpPost]
        public async Task<ActionResult<List<Genero>>> AddGenero(Genero genero)
        {
            var result = await _generoService.AddGenero(genero);
            return Ok(result);
        }

        // Atualização
        [HttpPut]
        [Route("{id}")]
        public async Task<ActionResult<List<Genero>>> UpdateGenero(int id, Genero request)
        {
            var result = await _generoService.UpdateGenero(id, request);
            if (result is null)
                return NotFound();
            return Ok(result);
        }

        // Deletar
        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult<List<Genero>>> DeleteGenero(int id)
        {
            var result = await _generoService.DeleteGenero(id);
            if (result is null)
                return NotFound();
            return Ok(result);
        }
    }
}

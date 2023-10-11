using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        // Conexão com o Service do Modelo
        private readonly ILivroService _livroService;
        public LivroController(ILivroService livroService)
        {
            _livroService = livroService;
        }

        // Leitura
        [HttpGet]
        public async Task<ActionResult<List<Livro>>> GetAllLivros()
        {
            return await _livroService.GetAllLivros();
        }

        // Leitura através do ID
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Livro>> GetSingleLivro(int id)
        {
            var result = await _livroService.GetSingleLivro(id);
            if (result is null)
                return NotFound();
            return Ok(result);
        }

        // Criação
        [HttpPost]
        public async Task<ActionResult<List<Livro>>> AddLivro(Livro livro)
        {
            var result = await _livroService.AddLivro(livro);
            return Ok(result);
        }

        // Atualização
        [HttpPut]
        [Route("{id}")]
        public async Task<ActionResult<List<Livro>>> UpdateLivro(int id, Livro request)
        {
            var result = await _livroService.UpdateLivro(id, request);
            if (result is null)
                return NotFound();
            return Ok(result);
        }

        // Deletar
        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult<List<Genero>>> DeleteGenero(int id)
        {
            var result = await _livroService.DeleteLivro(id);
            if (result is null)
                return NotFound();
            return Ok(result);
        }
    }
}

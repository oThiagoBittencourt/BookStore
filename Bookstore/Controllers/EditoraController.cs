using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EditoraController : ControllerBase
    {
        // Conexão com o Service do Modelo
        private readonly IEditoraService _editoraService;
        public EditoraController(IEditoraService editoraService)
        {
            _editoraService = editoraService;
        }

        // Leitura
        [HttpGet]
        public async Task<ActionResult<List<Editora>>> GetAllEditoras()
        {
            return await _editoraService.GetAllEditoras();
        }

        // Leitura através do ID
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Editora>> GetSingleEditora(int id)
        {
            var result = await _editoraService.GetSingleEditora(id);
            if (result is null)
                return NotFound();
            return Ok(result);
        }

        // Criação
        [HttpPost]
        public async Task<ActionResult<List<Editora>>> AddEditora(Editora editora)
        {
            var result = await _editoraService.AddEditora(editora);
            return Ok(result);
        }

        // Atualização
        [HttpPut]
        [Route("{id}")]
        public async Task<ActionResult<List<Autor>>> UpdateEditora(int id, Editora request)
        {
            var result = await _editoraService.UpdateEditora(id, request);
            if (result is null)
                return NotFound();
            return Ok(result);
        }

        // Deletar
        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult<List<Autor>>> DeleteEditora(int id)
        {
            var result = await _editoraService.DeleteEditora(id);
            if (result is null)
                return NotFound();
            return Ok(result);
        }
    }
}

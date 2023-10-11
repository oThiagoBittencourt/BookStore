// Documentação dos Services está em um .txt na pasta Services
namespace Bookstore.Services.EditoraService
{
    public class EditoraService : IEditoraService
    {
        private readonly DataContext _context;

        public EditoraService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Editora>> AddEditora(Editora editora)
        {
            _context.Editoras.Add(editora);
            await _context.SaveChangesAsync();
            return await _context.Editoras.ToListAsync();
        }

        public async Task<List<Editora>?> DeleteEditora(int id)
        {
            var editora = await _context.Editoras.FindAsync(id);
            if (editora is null)
                return null;
            _context.Editoras.Remove(editora);
            await _context.SaveChangesAsync();

            return await _context.Editoras.ToListAsync();
        }

        public async Task<List<Editora>> GetAllEditoras()
        {
            var editoras = await _context.Editoras.ToListAsync();
            return editoras;
        }

        public async Task<Editora?> GetSingleEditora(int id)
        {
            var editora = await _context.Editoras.FindAsync(id);
            if (editora is null)
                return null;
            return editora;
        }

        public async Task<List<Editora>?> UpdateEditora(int id, Editora request)
        {
            var editora = await _context.Autores.FindAsync(id);
            if (editora is null)
                return null;
            editora.Nome = request.Nome;

            await _context.SaveChangesAsync();

            return await _context.Editoras.ToListAsync();
        }
    }
}
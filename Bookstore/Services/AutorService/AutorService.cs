// Documentação dos Services está em um .txt na pasta Services
namespace Bookstore.Services.AutorService
{
    public class AutorService : IAutorService
    {
        private readonly DataContext _context;

        public AutorService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Autor>> AddAutor(Autor autor)
        {
            _context.Autores.Add(autor);
            await _context.SaveChangesAsync();
            return await _context.Autores.ToListAsync();
        }

        public async Task<List<Autor>?> DeleteAutor(int id)
        {
            var autor = await _context.Autores.FindAsync(id);
            if (autor is null)
                return null;
            _context.Autores.Remove(autor);
            await _context.SaveChangesAsync();

            return await _context.Autores.ToListAsync();
        }

        public async Task<List<Autor>> GetAllAutores()
        {
            var autores = await _context.Autores.ToListAsync();
            return autores;
        }

        public async Task<Autor?> GetSingleAutor(int id)
        {
            var autor = await _context.Autores.FindAsync(id);
            if (autor is null)
                return null;
            return autor;
        }

        public async Task<List<Autor>?> UpdateAutor(int id, Autor request)
        {
            var autor = await _context.Autores.FindAsync(id);
            if (autor is null)
                return null;
            autor.Nome = request.Nome;

            await _context.SaveChangesAsync();

            return await _context.Autores.ToListAsync();
        }
    }
}

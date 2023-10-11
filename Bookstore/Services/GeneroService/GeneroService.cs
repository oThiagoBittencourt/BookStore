// Documentação dos Services está em um .txt na pasta Services
namespace Bookstore.Services.GeneroService
{
    public class GeneroService : IGeneroService
    {
        private readonly DataContext _context;

        public GeneroService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Genero>> AddGenero(Genero genero)
        {
            _context.Generos.Add(genero);
            await _context.SaveChangesAsync();
            return await _context.Generos.ToListAsync();
        }

        public async Task<List<Genero>?> DeleteGenero(int id)
        {
            var genero = await _context.Generos.FindAsync(id);
            if (genero is null)
                return null;
            _context.Generos.Remove(genero);
            await _context.SaveChangesAsync();

            return await _context.Generos.ToListAsync();
        }

        public async Task<List<Genero>> GetAllGeneros()
        {
            var generos = await _context.Generos.ToListAsync();
            return generos;
        }

        public async Task<Genero?> GetSingleGenero(int id)
        {
            var genero = await _context.Generos.FindAsync(id);
            if (genero is null)
                return null;
            return genero;
        }

        public async Task<List<Genero>?> UpdateGenero(int id, Genero request)
        {
            var genero = await _context.Generos.FindAsync(id);
            if (genero is null)
                return null;
            genero.Nome = request.Nome;

            await _context.SaveChangesAsync();

            return await _context.Generos.ToListAsync();
        }
    }
}

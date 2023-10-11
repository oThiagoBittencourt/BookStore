// Documentação dos Services está em um .txt na pasta Services
namespace Bookstore.Services.LivroService
{
    public class LivroService : ILivroService
    {
        private readonly DataContext _context;

        public LivroService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Livro>> AddLivro(Livro livro)
        {
            _context.Livros.Add(livro);
            await _context.SaveChangesAsync();
            return await _context.Livros.ToListAsync();
        }

        public async Task<List<Livro>?> DeleteLivro(int id)
        {
            var livro = await _context.Livros.FindAsync(id);
            if (livro is null)
                return null;
            _context.Livros.Remove(livro);
            await _context.SaveChangesAsync();

            return await _context.Livros.ToListAsync();
        }

        public async Task<List<Livro>> GetAllLivros()
        {
            var livro = await _context.Livros.ToListAsync();
            return livro;
        }

        public async Task<Livro?> GetSingleLivro(int id)
        {
            var livro = await _context.Livros.FindAsync(id);
            if (livro is null)
                return null;
            return livro;
        }

        public async Task<List<Livro>?> UpdateLivro(int id, Livro request)
        {
            var livro = await _context.Livros.FindAsync(id);
            if (livro is null)
                return null;
            livro.Nome = request.Nome;
            livro.Valor = request.Valor;
            livro.QntEstoque = request.QntEstoque;

            await _context.SaveChangesAsync();

            return await _context.Livros.ToListAsync();
        }
    }
}

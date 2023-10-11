// Documentação dos Services está em um .txt na pasta Services
namespace Bookstore.Services.LivroService
{
    public interface ILivroService
    {
        Task<List<Livro>> GetAllLivros();
        Task<Livro?> GetSingleLivro(int id);
        Task<List<Livro>> AddLivro(Livro livro);
        Task<List<Livro>?> UpdateLivro(int id, Livro request);
        Task<List<Livro>?> DeleteLivro(int id);
    }
}

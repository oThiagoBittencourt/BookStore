// Documentação dos Services está em um .txt na pasta Services
namespace Bookstore.Services.AutorService
{
    public interface IAutorService
    {
        Task<List<Autor>> GetAllAutores();
        Task<Autor?> GetSingleAutor(int id);
        Task<List<Autor>> AddAutor(Autor autor);
        Task<List<Autor>?> UpdateAutor(int id, Autor request);
        Task<List<Autor>?> DeleteAutor(int id);
    }
}

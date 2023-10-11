// Documentação dos Services está em um .txt na pasta Services
namespace Bookstore.Services.GeneroService
{
    public interface IGeneroService
    {
        Task<List<Genero>> GetAllGeneros();
        Task<Genero?> GetSingleGenero(int id);
        Task<List<Genero>> AddGenero(Genero genero);
        Task<List<Genero>?> UpdateGenero(int id, Genero request);
        Task<List<Genero>?> DeleteGenero(int id);
    }
}

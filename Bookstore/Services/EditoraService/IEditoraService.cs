// Documentação dos Services está em um .txt na pasta Services
namespace Bookstore.Services.EditoraService
{
    public interface IEditoraService
    {
        Task<List<Editora>> GetAllEditoras();
        Task<Editora?> GetSingleEditora(int id);
        Task<List<Editora>> AddEditora(Editora editora);
        Task<List<Editora>?> UpdateEditora(int id, Editora request);
        Task<List<Editora>?> DeleteEditora(int id);
    }
}

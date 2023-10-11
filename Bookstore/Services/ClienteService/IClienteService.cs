// Documentação dos Services está em um .txt na pasta Services
namespace Bookstore.Services.ClienteService
{
    public interface IClienteService
    {
        Task<List<Cliente>> GetAllClientes();
        Task<Cliente?> GetSingleCliente(int id);
        Task<List<Cliente>> AddCliente(Cliente cliente);
        Task<List<Cliente>?> UpdateCliente(int id, Cliente request);
        Task<List<Cliente>?> DeleteCliente(int id);
    }
}

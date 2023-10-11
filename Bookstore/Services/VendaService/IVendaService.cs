// Documentação dos Services está em um .txt na pasta Services
namespace Bookstore.Services.VendaService
{
    public interface IVendaService
    {
        Task<List<Venda>> GetAllVendas();
        Task<Venda?> GetSingleVenda(int id);
        Task<List<Venda>> AddVenda(Venda venda);
        Task<List<Venda>?> DeleteVenda(int id);
    }
}

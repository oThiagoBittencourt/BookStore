// Documentação dos Services está em um .txt na pasta Services
namespace Bookstore.Services.VendaService
{
    public class VendaService : IVendaService
    {
        private readonly DataContext _context;

        public VendaService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Venda>> AddVenda(Venda venda)
        {
            _context.Vendas.Add(venda);
            await _context.SaveChangesAsync();
            return await _context.Vendas.ToListAsync();
        }

        public async Task<List<Venda>?> DeleteVenda(int id)
        {
            var venda = await _context.Vendas.FindAsync(id);
            if (venda is null)
                return null;
            _context.Vendas.Remove(venda);
            await _context.SaveChangesAsync();

            return await _context.Vendas.ToListAsync();
        }

        public async Task<List<Venda>> GetAllVendas()
        {
            var venda = await _context.Vendas.ToListAsync();
            return venda;
        }

        public async Task<Venda?> GetSingleVenda(int id)
        {
            var venda = await _context.Vendas.FindAsync(id);
            if (venda is null)
                return null;
            return venda;
        }
    }
}

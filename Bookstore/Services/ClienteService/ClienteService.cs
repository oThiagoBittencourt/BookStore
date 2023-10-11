// Documentação dos Services está em um .txt na pasta Services
namespace Bookstore.Services.ClienteService
{
    public class ClienteService : IClienteService
    {
        private readonly DataContext _context;

        public ClienteService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Cliente>> AddCliente(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();
            return await _context.Clientes.ToListAsync();
        }

        public async Task<List<Cliente>?> DeleteCliente(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente is null)
                return null;
            _context.Clientes.Remove(cliente);
            await _context.SaveChangesAsync();

            return await _context.Clientes.ToListAsync();
        }

        public async Task<List<Cliente>> GetAllClientes()
        {
            var cliente = await _context.Clientes.ToListAsync();
            return cliente;
        }

        public async Task<Cliente?> GetSingleCliente(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente is null)
                return null;
            return cliente;
        }

        public async Task<List<Cliente>?> UpdateCliente(int id, Cliente request)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente is null)
                return null;
            cliente.Nome = request.Nome;

            await _context.SaveChangesAsync();

            return await _context.Clientes.ToListAsync();
        }
    }
}

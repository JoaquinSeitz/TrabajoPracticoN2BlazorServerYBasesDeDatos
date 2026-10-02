using Microsoft.EntityFrameworkCore;
using TrabajoPracticoN2BlazorServerYBasesDeDatos.Data;
using TrabajoPracticoN2BlazorServerYBasesDeDatos.Models;

namespace TrabajoPracticoN2BlazorServerYBasesDeDatos.Services
{
    public class ClienteService
    {
        private readonly ApplicationDbContext _context;

        public ClienteService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Cliente>> GetClientesAsync() => await _context.Clientes.ToListAsync();

        public async Task<Cliente?> GetClienteByIdAsync(int id) => await _context.Clientes.FindAsync(id);

        public async Task AddClienteAsync(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateClienteAsync(Cliente cliente)
        {
            _context.Clientes.Update(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteClienteAsync(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                await _context.SaveChangesAsync();
            }
        }
    }
}
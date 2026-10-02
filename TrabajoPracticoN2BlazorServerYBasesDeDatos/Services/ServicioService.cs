using Microsoft.EntityFrameworkCore;
using TrabajoPracticoN2BlazorServerYBasesDeDatos.Data;
using TrabajoPracticoN2BlazorServerYBasesDeDatos.Models;

namespace TrabajoPracticoN2BlazorServerYBasesDeDatos.Services
{
    public class ServicioService
    {
        private readonly ApplicationDbContext _context;

        public ServicioService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Servicio>> GetServiciosAsync() => await _context.Servicios.ToListAsync();

        public async Task<Servicio?> GetServicioByIdAsync(int id) => await _context.Servicios.FindAsync(id);

        public async Task AddServicioAsync(Servicio servicio)
        {
            _context.Servicios.Add(servicio);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateServicioAsync(Servicio servicio)
        {
            _context.Servicios.Update(servicio);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteServicioAsync(int id)
        {
            var servicio = await _context.Servicios.FindAsync(id);
            if (servicio != null)
            {
                _context.Servicios.Remove(servicio);
                await _context.SaveChangesAsync();
            }
        }
    }
}
using Microsoft.EntityFrameworkCore;
using TrabajoPracticoN2BlazorServerYBasesDeDatos.Data;
using TrabajoPracticoN2BlazorServerYBasesDeDatos.Models;

namespace TrabajoPracticoN2BlazorServerYBasesDeDatos.Services
{
    public class TurnoService
    {
        private readonly ApplicationDbContext _context;

        public TurnoService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Turno>> GetTurnosAsync()
        {
            // Usamos Include para cargar las relaciones y OrderBy para ordenarlos por fecha
            return await _context.Turnos
                .Include(t => t.Cliente)
                .Include(t => t.Servicio)
                .OrderBy(t => t.FechaHora)
                .ToListAsync();
        }

        public async Task<Turno?> GetTurnoByIdAsync(int id) => await _context.Turnos.FindAsync(id);

        public async Task AddTurnoAsync(Turno turno)
        {
            _context.Turnos.Add(turno);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTurnoAsync(Turno turno)
        {
            _context.Turnos.Update(turno);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTurnoAsync(int id)
        {
            var turno = await _context.Turnos.FindAsync(id);
            if (turno != null)
            {
                _context.Turnos.Remove(turno);
                await _context.SaveChangesAsync();
            }
        }
    }
}
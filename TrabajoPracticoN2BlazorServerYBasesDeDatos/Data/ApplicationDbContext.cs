using Microsoft.EntityFrameworkCore;
using TrabajoPracticoN2BlazorServerYBasesDeDatos.Models;

namespace TrabajoPracticoN2BlazorServerYBasesDeDatos.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<Turno> Turnos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seeding de Clientes
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente { Id = 1, Nombre = "Laura", Apellido = "Gómez", Telefono = "2954-15223344", Email = "laura.gomez@email.com" },
                new Cliente { Id = 2, Nombre = "Sofía", Apellido = "Martínez", Telefono = "2954-15667788", Email = "sofia.m@email.com" }
            );

            // Seeding de Servicios
            modelBuilder.Entity<Servicio>().HasData(
                new Servicio { Id = 1, Nombre = "Limpieza Facial", Descripcion = "Incluye extracción y máscara hidratante", Precio = 15000.00m },
                new Servicio { Id = 2, Nombre = "Masaje Descontracturante", Descripcion = "Sesión de 45 minutos", Precio = 12000.00m },
                new Servicio { Id = 3, Nombre = "Manicura Semipermanente", Descripcion = "Esmaltado de larga duración", Precio = 8500.00m }
            );

            // Seeding de Turnos
            modelBuilder.Entity<Turno>().HasData(
                new Turno { Id = 1, FechaHora = new DateTime(2026, 10, 15, 10, 0, 0), ClienteId = 1, ServicioId = 1, Observaciones = "Primera visita al centro" },
                new Turno { Id = 2, FechaHora = new DateTime(2026, 10, 15, 11, 30, 0), ClienteId = 2, ServicioId = 3, Observaciones = "" }
            );
        }
    }
}
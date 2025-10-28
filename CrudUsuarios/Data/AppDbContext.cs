// Entity Framework Core version: 7.0.0(2 files)
using Microsoft.EntityFrameworkCore;
using CrudUsuarios.Models;

namespace CrudUsuarios.Data
{
    public class AppDbContext : DbContext
    {
        // 👇 Constructor que recibe las opciones de configuración (4 files)
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // 👇 Aquí defines las tablas que quieres crear en la BD (1 file)
        public DbSet<Usuarios> Usuarios { get; set; }
    }
}

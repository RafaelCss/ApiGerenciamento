using Application.Classes;
using Microsoft.EntityFrameworkCore;

namespace Application.Contexto
{
    public class ContextoUsuario : DbContext
    {
        public ContextoUsuario(DbContextOptions<ContextoUsuario> options) : base(options)
        { }

        public DbSet<Usuario> Usuarios { get; set; } = null!;
    }
}

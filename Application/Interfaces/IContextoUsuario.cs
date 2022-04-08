using Application.Classes;
using Microsoft.EntityFrameworkCore;

namespace Application.Contexto
{
    public interface IContextoUsuario
    {
        DbSet<Usuario> Usuarios { get; set; }
    }
}
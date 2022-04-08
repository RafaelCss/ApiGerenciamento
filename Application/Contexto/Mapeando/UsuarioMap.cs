using Application.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.Contexto.Mapeando
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        

        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("cadastro");

            builder.HasKey(t => t.id);
            builder.Property(t => t.id).HasColumnName("id");
            builder.Property(t => t.name).HasColumnName("name");
            builder.Property(t => t.user).HasColumnName("user");
            builder.Property(t => t.email).HasColumnName("email");
            builder.Property(t => t.password).HasColumnName("password");
            builder.Property(t => t.updatedAt).HasColumnName("updatedAt");
            builder.Property(t => t.createdAt).HasColumnName("createdAt");
        }
    }
}

using Microsoft.EntityFrameworkCore;
using TrabajoIntegrador.Entities;

namespace TrabajoIntegrador.DataAccess.DataBaseSeeding
{
    public class UsuarioSeeder : IEntitySeeder
    {
        public void SeedDataBase(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario
                {
                    Id = 1,
                    Nombre = "test",
                    Dni = 1,
                    Tipo = 1,
                    Clave = "123"
                });
        }
    }
}


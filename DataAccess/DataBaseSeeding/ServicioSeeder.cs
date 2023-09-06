using Microsoft.EntityFrameworkCore;
using TrabajoIntegrador.Entities;

namespace TrabajoIntegrador.DataAccess.DataBaseSeeding
{
    public class ServicioSeeder : IEntitySeeder
    {
        public void SeedDataBase(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Servicio>().HasData(
                new Servicio
                {
                    Id = 1,
                    Descripcion = "test",
                    Estado = true,
                    ValorHora = 10
                });
        }
    }
}


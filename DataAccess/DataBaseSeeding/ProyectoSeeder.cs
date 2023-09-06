using Microsoft.EntityFrameworkCore;
using TrabajoIntegrador.Entities;

namespace TrabajoIntegrador.DataAccess.DataBaseSeeding
{
    public class ProyectoSeeder : IEntitySeeder
    {
        public void SeedDataBase(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Proyecto>().HasData(
                new Proyecto
                {
                    Id = 1,
                    Nombre = "test",
                    Direccion = "test",
                    Estado = 1
                });
        }
    }
}

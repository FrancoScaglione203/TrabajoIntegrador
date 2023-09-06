using Microsoft.EntityFrameworkCore;
using TrabajoIntegrador.Entities;

namespace TrabajoIntegrador.DataAccess.DataBaseSeeding
{
    public class TrabajoSeeder : IEntitySeeder
    {
        public void SeedDataBase(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trabajo>().HasData(
                new Trabajo
                {
                    Id = 1,
                    Fecha = DateTime.Now,
                    IdProyecto = 1,
                    IdServicio = 1,
                    CantHoras = 1,
                    ValorHora = 10,
                    Costo = 10
                });
        }
    }
}

﻿namespace TrabajoIntegrador.DTOs
{
    public class TrabajoDto
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int IdProyecto { get; set; }
        public int IdServicio { get; set; }
        public int CantHoras { get; set; }
        public decimal ValorHora { get; set; }
        public decimal Costo { get; set; }
    }
}

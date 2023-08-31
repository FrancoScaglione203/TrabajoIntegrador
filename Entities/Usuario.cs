namespace TrabajoIntegrador.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Dni { get; set; }
        public int tipo { get; set; }  //Despues ver como hacer para que el dato asigne descripcion a 1 y 2
        public string contraseña { get; set; }
    }
}

namespace FinalProgramacion.Models
{
    public class Deposito
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Activo { get; set; }
        public int metrosCuadrados { get; set; }
        public string calle { get; set; }
        public string numero { get; set; }
        public int BarrioId { get; set; }
        public Barrio Barrio { get; set; }
    }
}

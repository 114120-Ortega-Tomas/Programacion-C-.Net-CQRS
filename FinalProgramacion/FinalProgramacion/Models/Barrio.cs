namespace FinalProgramacion.Models
{
    public class Barrio
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CiudadId { get; set; }
        public Ciudad Ciudad { get; set; }
    }
}

﻿namespace FinalProgramacion.Models
{
    public class Ciudad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int PaisId { get; set; }
        public Pais pais { get; set; }
    }
}

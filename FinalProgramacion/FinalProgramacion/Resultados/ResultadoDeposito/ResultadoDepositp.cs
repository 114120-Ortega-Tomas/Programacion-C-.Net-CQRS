namespace FinalProgramacion.Resultados.ResultadoDeposito
{
    public class ResultadoDepositp : ResultadoBase
    {
        public List<ItemDeposito> listDepositos { get; set; }= new List<ItemDeposito>();
    }
    public class ItemDeposito
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Activo { get; set; }
        public int metrosCuadrados { get; set; }
        public string calle { get; set; }
        public string numero { get; set; }
        public string Barrio { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }
    }
}

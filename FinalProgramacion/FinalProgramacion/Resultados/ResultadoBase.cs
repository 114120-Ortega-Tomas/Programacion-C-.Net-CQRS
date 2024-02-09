using System.Net;

namespace FinalProgramacion.Resultados
{
    public class ResultadoBase
    {
        public bool Ok { get; set; } = true;
        public string mensaje { get; set; } = "SUCCESS";
        public HttpStatusCode Status { get; set; } = HttpStatusCode.OK;

        public void Respuesta(string msj, HttpStatusCode code)
        {
            Ok = false;
            mensaje = msj;
            Status = code;
        }
    }
}
